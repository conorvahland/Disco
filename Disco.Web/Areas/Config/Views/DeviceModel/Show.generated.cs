﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Areas.Config.Views.DeviceModel
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Disco;
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Services;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/DeviceModel/Show.cshtml")]
    public partial class Show : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.DeviceModel.ShowModel>
    {
        public Show()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
  
    Authorization.Require(Claims.Config.DeviceModel.Show);

    var canConfig = Authorization.Has(Claims.Config.DeviceModel.Configure);
    var canViewPlugins = Authorization.Has(Claims.Config.Plugin.Install);

    if (canConfig)
    {
        Html.BundleDeferred("~/ClientScripts/Modules/Disco-PropertyChangeHelpers");
    }

    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Device Models", MVC.Config.DeviceModel.Index(null), Model.DeviceModel.ToString());

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 530px\"");

WriteLiteral(">\r\n    <table>\r\n        <tr>\r\n            <th");

WriteLiteral(" style=\"width: 150px\"");

WriteLiteral(">Id:\r\n            </th>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 21 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(Html.DisplayFor(model => model.DeviceModel.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>Description:\r\n " +
"           </th>\r\n            <td>");

            
            #line 27 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                 if (canConfig)
                {
                
            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(Html.EditorFor(model => model.DeviceModel.Description));

            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                                                       
                
            
            #line default
            #line hidden
            
            #line 30 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(AjaxHelpers.AjaxSave());

            
            #line default
            #line hidden
            
            #line 30 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                       
                
            
            #line default
            #line hidden
            
            #line 31 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
            
            #line 31 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                         

            
            #line default
            #line hidden
WriteLiteral(@"                <script>
                    $(function () {
                        document.DiscoFunctions.PropertyChangeHelper(
                            $('#DeviceModel_Description'),
                            'Model Description',
                            '");

            
            #line 37 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                        Write(Url.Action(MVC.API.DeviceModel.UpdateDescription(Model.DeviceModel.Id)));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                            \'Description\'\r\n                        );\r\n      " +
"              });\r\n                </script>\r\n");

            
            #line 42 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                }
                else
                {
                
            
            #line default
            #line hidden
            
            #line 45 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(Html.DisplayFor(model => model.DeviceModel.Description));

            
            #line default
            #line hidden
            
            #line 45 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                                                        
                }

            
            #line default
            #line hidden
WriteLiteral("            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>Manufacturer:\r\n  " +
"          </th>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 53 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(Html.DisplayFor(model => model.DeviceModel.Manufacturer));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>Model:\r\n       " +
"     </th>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 60 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(Html.DisplayFor(model => model.DeviceModel.Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>Statistics</th>" +
"\r\n            <td>\r\n                <div><strong>");

            
            #line 66 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                        Write(Model.DeviceCount.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</strong> ");

            
            #line 66 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                                                    Write(Model.DeviceCount == 1 ? "devices is" : "devices are");

            
            #line default
            #line hidden
WriteLiteral(" of this model type.</div>\r\n");

            
            #line 67 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                
            
            #line default
            #line hidden
            
            #line 67 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                 if (Model.DeviceDecommissionedCount > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">");

            
            #line 69 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                         Write(Model.DeviceDecommissionedCount.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 69 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                                                                          Write(Model.DeviceDecommissionedCount == 1 ? "device is" : "devices are");

            
            #line default
            #line hidden
WriteLiteral(" decommissioned.</div>\r\n");

            
            #line 70 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>Default Purchase " +
"Date:\r\n            </th>\r\n            <td>");

            
            #line 76 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                 if (canConfig)
                {
                
            
            #line default
            #line hidden
            
            #line 78 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(Html.EditorFor(model => model.DeviceModel.DefaultPurchaseDate));

            
            #line default
            #line hidden
            
            #line 78 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                                                               
                
            
            #line default
            #line hidden
            
            #line 79 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
            
            #line 79 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                         

            
            #line default
            #line hidden
WriteLiteral(@"                <script>
                    $(function () {
                        var dateField = $('#DeviceModel_DefaultPurchaseDate');
                        document.DiscoFunctions.DateChangeHelper(
                        dateField,
                        'None',
                        '");

            
            #line 86 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                     Write(Url.Action(MVC.API.DeviceModel.UpdateDefaultPurchaseDate(Model.DeviceModel.Id)));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                        \'DefaultPurchaseDate\',\r\n                        null," +
"\r\n                        true\r\n                        );\r\n                    " +
"});\r\n                </script>\r\n");

            
            #line 93 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                }
                else
                {
                
            
            #line default
            #line hidden
            
            #line 96 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(CommonHelpers.FriendlyDate(Model.DeviceModel.DefaultPurchaseDate, "Unknown"));

            
            #line default
            #line hidden
            
            #line 96 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                                                                             
                }

            
            #line default
            #line hidden
WriteLiteral("            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>Default Warranty " +
"Provider:\r\n            </th>\r\n            <td>");

            
            #line 103 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                 if (canConfig)
                {
                    if (Model.WarrantyProviders.Count > 0)
                    {
                
            
            #line default
            #line hidden
            
            #line 107 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(Html.DropDownListFor(model => model.DeviceModel.DefaultWarrantyProvider, Model.WarrantyProviders.ToSelectListItems(Model.DeviceModel.DefaultWarrantyProvider, true, "None")));

            
            #line default
            #line hidden
            
            #line 107 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                                                                                                                                                                             
                
            
            #line default
            #line hidden
            
            #line 108 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
            
            #line 108 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                         

            
            #line default
            #line hidden
WriteLiteral(@"                <script>
                    $(function () {
                        document.DiscoFunctions.PropertyChangeHelper(
                            $('#DeviceModel_DefaultWarrantyProvider'),
                            null,
                            '");

            
            #line 114 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                        Write(Url.Action(MVC.API.DeviceModel.UpdateDefaultWarrantyProvider(Model.DeviceModel.Id)));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                            \'DefaultWarrantyProvider\'\r\n                      " +
"  );\r\n                    });\r\n                </script>\r\n");

            
            #line 119 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No warranty provider plugins installed</span>\r\n");

            
            #line 123 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                    }
                    if (canViewPlugins)
                    {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"info-box\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"fa-p\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"fa fa-info-circle\"");

WriteLiteral("></i>View the <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5025), Tuple.Create("\"", 5075)
            
            #line 128 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
, Tuple.Create(Tuple.Create("", 5032), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Config.Plugins.Install())
            
            #line default
            #line hidden
, 5032), false)
);

WriteLiteral(">Plugin Catalogue</a> to discover and install warranty provider plugins.\r\n       " +
"             </p>\r\n                </div>\r\n");

            
            #line 131 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                    }
                }
                else
                {
                    if (Model.DeviceModel.DefaultWarrantyProvider == null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">&lt;None Specified&gt;</span>\r\n");

            
            #line 138 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                    }
                    else
                    {
                        var provider = Model.WarrantyProviders.FirstOrDefault(wp => wp.Id == Model.DeviceModel.DefaultWarrantyProvider);
                        if (provider == null)
                        {

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">&lt;None Specified&gt;</span>\r\n");

            
            #line 145 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                        }
                        else
                        {
                
            
            #line default
            #line hidden
            
            #line 148 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(provider.Name);

            
            #line default
            #line hidden
            
            #line 148 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                              
                        }
                    }
                }

            
            #line default
            #line hidden
WriteLiteral("            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>Default Repair Pr" +
"ovider:\r\n            </th>\r\n            <td>");

            
            #line 157 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                 if (canConfig)
                {
                    if (Model.RepairProviders.Count > 0)
                    {
                
            
            #line default
            #line hidden
            
            #line 161 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(Html.DropDownListFor(model => model.DeviceModel.DefaultRepairProvider, Model.RepairProviders.ToSelectListItems(Model.DeviceModel.DefaultRepairProvider, true, "None")));

            
            #line default
            #line hidden
            
            #line 161 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                                                                                                                                                                       
                
            
            #line default
            #line hidden
            
            #line 162 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
            
            #line 162 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                         

            
            #line default
            #line hidden
WriteLiteral(@"                <script>
                    $(function () {
                        document.DiscoFunctions.PropertyChangeHelper(
                            $('#DeviceModel_DefaultRepairProvider'),
                            null,
                            '");

            
            #line 168 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                        Write(Url.Action(MVC.API.DeviceModel.UpdateDefaultRepairProvider(Model.DeviceModel.Id)));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                            \'DefaultRepairProvider\'\r\n                        " +
");\r\n                    });\r\n                </script>\r\n");

            
            #line 173 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                <div>No repair provider plugins installed</div>\r\n");

            
            #line 177 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                    }
                    if (canViewPlugins)
                    {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"info-box\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"fa-p\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"fa fa-info-circle\"");

WriteLiteral("></i>View the <a");

WriteAttribute("href", Tuple.Create(" href=\"", 7326), Tuple.Create("\"", 7376)
            
            #line 182 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
, Tuple.Create(Tuple.Create("", 7333), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Config.Plugins.Install())
            
            #line default
            #line hidden
, 7333), false)
);

WriteLiteral(">Plugin Catalogue</a> to discover and install repair provider plugins.\r\n         " +
"           </p>\r\n                </div>\r\n");

            
            #line 185 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                    }
                }
                else
                {
                    if (Model.DeviceModel.DefaultRepairProvider == null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">&lt;None Specified&gt;</span>\r\n");

            
            #line 192 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                    }
                    else
                    {
                        var provider = Model.RepairProviders.FirstOrDefault(wp => wp.Id == Model.DeviceModel.DefaultRepairProvider);
                        if (provider == null)
                        {

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">&lt;None Specified&gt;</span>\r\n");

            
            #line 199 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                        }
                        else
                        {
                
            
            #line default
            #line hidden
            
            #line 202 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(provider.Name);

            
            #line default
            #line hidden
            
            #line 202 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                              
                        }
                    }
                }

            
            #line default
            #line hidden
WriteLiteral("            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>Type:\r\n          " +
"  </th>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 212 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
           Write(Html.DisplayFor(model => model.DeviceModel.ModelType));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>Image:\r\n       " +
"     </th>\r\n            <td>\r\n                <img");

WriteLiteral(" alt=\"Model Image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 8619), Tuple.Create("\"", 8716)
            
            #line 219 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
, Tuple.Create(Tuple.Create("", 8625), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.DeviceModel.Image(Model.DeviceModel.Id, Model.DeviceModel.ImageHash()))
            
            #line default
            #line hidden
, 8625), false)
);

WriteLiteral(" />\r\n");

            
            #line 220 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                
            
            #line default
            #line hidden
            
            #line 220 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                 if (canConfig)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <hr />\r\n");

            
            #line 223 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                    using (Html.BeginForm(MVC.API.DeviceModel.Image(Model.DeviceModel.Id, true, null), FormMethod.Post, new { enctype = "multipart/form-data" }))
                    {

            
            #line default
            #line hidden
WriteLiteral("                    <input");

WriteLiteral(" type=\"file\"");

WriteLiteral(" name=\"Image\"");

WriteLiteral(" id=\"Image\"");

WriteLiteral(" style=\"width: 220px;\"");

WriteLiteral(" />\r\n");

WriteLiteral("                    <input");

WriteLiteral(" class=\"button small\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Upload Image\"");

WriteLiteral(" />\r\n");

            
            #line 227 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                    }
                }

            
            #line default
            #line hidden
WriteLiteral("            </td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n<h2>Components</h2>\r\n");

            
            #line 234 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
Write(Html.Partial(MVC.Config.DeviceModel.Views._DeviceComponentsTable, Model.DeviceComponentsModel));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n");

            
            #line 236 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
    
            
            #line default
            #line hidden
            
            #line 236 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
     if (Model.CanDelete)
    { 
        
            
            #line default
            #line hidden
            
            #line 238 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
   Write(Html.ActionLinkButton("Delete", MVC.API.DeviceModel.Delete(Model.DeviceModel.Id, true), "buttonDelete"));

            
            #line default
            #line hidden
            
            #line 238 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                                                                                                
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 240 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
     if (Model.DeviceCount > 0)
    {
        if (Authorization.Has(Claims.Device.Actions.Export))
        {
        
            
            #line default
            #line hidden
            
            #line 244 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
   Write(Html.ActionLinkButton("Export Devices", MVC.Device.Export(null, Disco.Models.Services.Devices.Exporting.DeviceExportTypes.Model, Model.DeviceModel.Id)));

            
            #line default
            #line hidden
            
            #line 244 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                                                                                                                                                
        }
        if (Authorization.Has(Claims.Device.Search) && Model.DeviceCount > 0)
        {
        
            
            #line default
            #line hidden
            
            #line 248 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
   Write(Html.ActionLinkButton(string.Format("View {0} Device{1}", Model.DeviceCount, (Model.DeviceCount != 1 ? "s" : null)), MVC.Search.Query(Model.DeviceModel.Id.ToString(), "DeviceModel")));

            
            #line default
            #line hidden
            
            #line 248 "..\..\Areas\Config\Views\DeviceModel\Show.cshtml"
                                                                                                                                                                                               
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
