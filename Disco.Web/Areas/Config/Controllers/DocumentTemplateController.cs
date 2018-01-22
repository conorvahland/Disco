﻿using Disco.BI.Extensions;
using Disco.Models.Repository;
using Disco.Models.UI.Config.DocumentTemplate;
using Disco.Services;
using Disco.Services.Authorization;
using Disco.Services.Documents;
using Disco.Services.Documents.ManagedGroups;
using Disco.Services.Expressions;
using Disco.Services.Plugins.Features.UIExtension;
using Disco.Services.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Disco.Web.Areas.Config.Controllers
{
    public partial class DocumentTemplateController : AuthorizedDatabaseController
    {
        [DiscoAuthorize(Claims.Config.DocumentTemplate.Show)]
        public virtual ActionResult Index(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                var m = new Models.DocumentTemplate.IndexModel()
                {
                    DocumentTemplates = Database.DocumentTemplates
                        .Select(dt => new
                        {
                            documentTemplate = dt,
                            storedInstances =
                                Database.DeviceAttachments.Count(a => a.DocumentTemplateId == dt.Id) +
                                Database.JobAttachments.Count(a => a.DocumentTemplateId == dt.Id) +
                                Database.UserAttachments.Count(a => a.DocumentTemplateId == dt.Id)
                        })
                        .ToDictionary(i => i.documentTemplate, i => i.storedInstances),
                    Packages = DocumentTemplatePackages.GetPackages()
                };

                // UI Extensions
                UIExtensions.ExecuteExtensions<ConfigDocumentTemplateIndexModel>(this.ControllerContext, m);

                return View(m);
            }
            else
            {
                // Normal Document Template
                var m = new Models.DocumentTemplate.ShowModel()
                {
                    DocumentTemplate = Database.DocumentTemplates.Include("JobSubTypes").FirstOrDefault(at => at.Id == id)
                };
                if (m.DocumentTemplate == null)
                    throw new ArgumentException("Invalid Document Template Id", nameof(id));

                m.TemplatePagesHaveAttachmentId = m.DocumentTemplate.PdfPageHasAttachmentId(Database);
                m.TemplateExpressions = m.DocumentTemplate.ExtractPdfExpressions(Database);
                m.UpdateModel(Database);

                DocumentTemplateDevicesManagedGroup devicesManagedGroup;
                if (DocumentTemplateDevicesManagedGroup.TryGetManagedGroup(m.DocumentTemplate, out devicesManagedGroup))
                    m.DevicesLinkedGroup = devicesManagedGroup;
                DocumentTemplateUsersManagedGroup usersManagedGroup;
                if (DocumentTemplateUsersManagedGroup.TryGetManagedGroup(m.DocumentTemplate, out usersManagedGroup))
                    m.UsersLinkedGroup = usersManagedGroup;

                // UI Extensions
                UIExtensions.ExecuteExtensions<ConfigDocumentTemplateShowModel>(this.ControllerContext, m);

                return View(MVC.Config.DocumentTemplate.Views.Show, m);
            }
        }

        public virtual ActionResult ShowPackage(string id)
        {
            // Document Template Package
            var m = new Models.DocumentTemplate.ShowPackageModel()
            {
                Package = DocumentTemplatePackages.GetPackage(id)
            };
            if (m.Package == null)
                throw new ArgumentException("Invalid Document Template Package Id", nameof(id));

            if (m.Package.Scope == AttachmentTypes.Job)
            {
                m.JobTypes = Database.JobTypes.Include("JobSubTypes").ToList();
                m.JobSubTypesSelected = m.Package.GetJobSubTypes(m.JobTypes.SelectMany(jt => jt.JobSubTypes));
            }
            var packageScopeString = m.Package.Scope.ToString();

            m.DocumentTemplates = Database.DocumentTemplates.Where(dt => dt.Scope == packageScopeString).ToList();
            m.DocumentTemplatesSelected = m.Package.GetDocumentTemplates(m.DocumentTemplates);

            // UI Extensions
            UIExtensions.ExecuteExtensions<ConfigDocumentTemplateShowPackageModel>(this.ControllerContext, m);

            return View(MVC.Config.DocumentTemplate.Views.ShowPackage, m);
        }

        [DiscoAuthorize(Claims.Config.DocumentTemplate.ShowStatus)]
        public virtual ActionResult ImportStatus()
        {
            var m = new Models.DocumentTemplate.ImportStatusModel();

            // UI Extensions
            UIExtensions.ExecuteExtensions<ConfigDocumentTemplateImportStatusModel>(this.ControllerContext, m);

            return View();
        }

        [DiscoAuthorize(Claims.Config.DocumentTemplate.UndetectedPages)]
        public virtual ActionResult UndetectedPages()
        {
            var m = new Models.DocumentTemplate.UndetectedPagesModel()
            {
                DocumentTemplates = Database.DocumentTemplates.ToList()
            };

            // UI Extensions
            UIExtensions.ExecuteExtensions<ConfigDocumentTemplateUndetectedPagesModel>(this.ControllerContext, m);

            return View(m);
        }

        [DiscoAuthorizeAll(Claims.Config.DocumentTemplate.Create, Claims.Config.DocumentTemplate.Configure)]
        public virtual ActionResult Create()
        {
            var m = new Models.DocumentTemplate.CreateModel();
            m.UpdateModel(Database);

            // UI Extensions
            UIExtensions.ExecuteExtensions<ConfigDocumentTemplateCreateModel>(this.ControllerContext, m);

            return View(m);
        }

        [DiscoAuthorizeAll(Claims.Config.DocumentTemplate.Create, Claims.Config.DocumentTemplate.Configure), HttpPost]
        public virtual ActionResult Create(Models.DocumentTemplate.CreateModel model)
        {
            model.UpdateModel(Database);

            if (ModelState.IsValid)
            {
                // Check for Existing
                var existing = Database.DocumentTemplates.Where(m => m.Id == model.DocumentTemplate.Id).FirstOrDefault();
                if (existing == null)
                {

                    Database.DocumentTemplates.Add(model.DocumentTemplate);

                    if (model.DocumentTemplate.Scope == Disco.Models.Repository.DocumentTemplate.DocumentTemplateScopes.Job)
                    {
                        var jobSubTypes = new List<Disco.Models.Repository.JobSubType>();
                        jobSubTypes.AddRange(model.GetJobSubTypes);
                        model.DocumentTemplate.JobSubTypes = jobSubTypes;
                        //foreach (var jobSubType in model.GetJobSubTypes)
                        //    model.AttachmentType.JobSubTypes.Add(jobSubType);
                    }

                    Database.SaveChanges();

                    // Save Template
                    model.DocumentTemplate.SavePdfTemplate(Database, model.Template.InputStream);

                    return RedirectToAction(MVC.Config.DocumentTemplate.Index(model.DocumentTemplate.Id));
                }
                else
                {
                    ModelState.AddModelError("Id", "A Document Template with this Id already exists.");
                }
            }

            // UI Extensions
            UIExtensions.ExecuteExtensions<ConfigDocumentTemplateCreateModel>(this.ControllerContext, model);

            return View(model);
        }

        [DiscoAuthorizeAll(Claims.Config.DocumentTemplate.Create, Claims.Config.DocumentTemplate.Configure)]
        public virtual ActionResult CreatePackage()
        {
            var m = new Models.DocumentTemplate.CreatePackageModel();

            // UI Extensions
            UIExtensions.ExecuteExtensions<ConfigDocumentTemplateCreatePackageModel>(this.ControllerContext, m);

            return View(m);
        }

        [DiscoAuthorizeAll(Claims.Config.DocumentTemplate.Create, Claims.Config.DocumentTemplate.Configure), HttpPost]
        public virtual ActionResult CreatePackage(Models.DocumentTemplate.CreatePackageModel model)
        {
            if (ModelState.IsValid)
            {
                // Check for Existing
                var existing = DocumentTemplatePackages.GetPackage(model.Package.Id);
                if (existing == null)
                {
                    DocumentTemplatePackages.CreatePackage(model.Package);

                    return RedirectToAction(MVC.Config.DocumentTemplate.ShowPackage(model.Package.Id));
                }
                else
                {
                    ModelState.AddModelError("Id", "A Document Template Package with this Id already exists.");
                }
            }

            // UI Extensions
            UIExtensions.ExecuteExtensions<ConfigDocumentTemplateCreatePackageModel>(this.ControllerContext, model);

            return View(model);
        }

        [DiscoAuthorize(Claims.Config.Show)]
        public virtual ActionResult ExpressionBrowser(string type, bool StaticDeclaredMembersOnly = false)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                var m = new Models.DocumentTemplate.ExpressionBrowserModel()
                {
                    DeviceType = typeof(Disco.Models.Repository.Device).AssemblyQualifiedName,
                    JobType = typeof(Disco.Models.Repository.Job).AssemblyQualifiedName,
                    UserType = typeof(Disco.Models.Repository.User).AssemblyQualifiedName,
                    Variables = Expression.StandardVariableTypes(),
                    ExtensionLibraries = Expression.ExtensionLibraryTypes()
                };

                // UI Extensions
                UIExtensions.ExecuteExtensions<ConfigDocumentTemplateExpressionBrowserModel>(this.ControllerContext, m);

                return View(m);
            }
            else
            {
                var t = Type.GetType(type);
                if (t != null)
                {
                    return Json(ExpressionTypeDescriptor.Build(t, StaticDeclaredMembersOnly), JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json("Invalid Type Specified", JsonRequestBehavior.AllowGet);
                }
            }
        }

    }
}
