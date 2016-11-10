﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Areas.Config.Views.DocumentTemplate
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
    using Disco.Models.Repository;
    using Disco.Services;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/DocumentTemplate/Index.cshtml")]
    public partial class Index : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.DocumentTemplate.IndexModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
  
    Authorization.Require(Claims.Config.DocumentTemplate.Show);

    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Document Templates");
    var showTags = Model.DocumentTemplates.Keys.Any(i => i.DevicesLinkedGroup != null || i.UsersLinkedGroup != null ||
        i.FilterExpression != null || i.OnGenerateExpression != null || i.OnImportAttachmentExpression != null);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 9 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
 if (Model.DocumentTemplates.Count == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 450px; padding: 100px 0;\"");

WriteLiteral(">\r\n        <h2>No document templates are configured</h2>\r\n    </div>\r\n");

            
            #line 14 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
}
else
{
    if (Model.DocumentTemplates.Keys.Any(dt => dt.IsHidden))
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" id=\"Config_DocumentTemplates_ShowHidden\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"button small\"");

WriteLiteral(">Show Hidden (");

            
            #line 19 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                                                                                           Write(Model.DocumentTemplates.Keys.Count(dt => dt.IsHidden));

            
            #line default
            #line hidden
WriteLiteral(")</a>\r\n");

WriteLiteral(@"            <script>
                $(function () {
                    $('#Config_DocumentTemplates_ShowHidden').click(function () {
                        $(this).remove();
                        $('#Config_DocumentTemplates_List').find('tr.hidden').show();
                        return false;
                    }).detach().appendTo('#layout_PageHeading');
                })
            </script>
");

            
            #line 29 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <table");

WriteLiteral(" id=\"Config_DocumentTemplates_List\"");

WriteLiteral(" class=\"tableData\"");

WriteLiteral(">\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Description</th>\r\n     " +
"       <th>Scope</th>\r\n            <th>Stored&nbsp;Instances</th>\r\n");

            
            #line 36 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 36 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
             if (showTags)
                {

            
            #line default
            #line hidden
WriteLiteral("                <th>&nbsp;</th>\r\n");

            
            #line 39 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n");

            
            #line 41 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 41 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
         foreach (var pair in Model.DocumentTemplates)
        {
            var item = pair.Key;
            var storedCount = pair.Value;

            
            #line default
            #line hidden
WriteLiteral("            <tr");

WriteAttribute("class", Tuple.Create(" class=\"", 1798), Tuple.Create("\"", 1840)
            
            #line 45 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1806), Tuple.Create<System.Object, System.Int32>(item.IsHidden ? "hidden" : null
            
            #line default
            #line hidden
, 1806), false)
);

WriteLiteral(">\r\n                <td>");

            
            #line 46 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
               Write(Html.ActionLink(item.Id.ToString(), MVC.Config.DocumentTemplate.Index(item.Id)));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 47 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 48 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Scope));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 49 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
               Write(storedCount.ToString("N0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 50 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 50 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                 if (showTags)
                    {

            
            #line default
            #line hidden
WriteLiteral("                    <td>\r\n");

            
            #line 53 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 53 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                         if (item.DevicesLinkedGroup != null || item.UsersLinkedGroup != null)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <i");

WriteLiteral(" class=\"fa fa-link fa-lg success\"");

WriteLiteral(" title=\"Is Linked\"");

WriteLiteral("></i>\r\n");

            
            #line 56 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 57 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                         if (item.FilterExpression != null || item.OnGenerateExpression != null || item.OnImportAttachmentExpression != null)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <i");

WriteLiteral(" class=\"fa fa-bolt fa-lg alert\"");

WriteLiteral(" title=\"Has Expressions\"");

WriteLiteral("></i>\r\n");

            
            #line 60 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 61 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                         if (item.IsHidden)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <i");

WriteLiteral(" class=\"fa fa-minus-square fa-lg error\"");

WriteLiteral(" title=\"Is Hidden\"");

WriteLiteral("></i>\r\n");

            
            #line 64 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n");

            
            #line 66 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 68 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </table>\r\n");

            
            #line 70 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n");

            
            #line 72 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 72 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
     if (Authorization.Has(Claims.Config.DocumentTemplate.UndetectedPages))
    {
        
            
            #line default
            #line hidden
            
            #line 74 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
   Write(Html.ActionLinkButton("Undetected Pages", MVC.Config.DocumentTemplate.UndetectedPages()));

            
            #line default
            #line hidden
            
            #line 74 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                                                                                                 
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 76 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
     if (Authorization.Has(Claims.Config.DocumentTemplate.ShowStatus))
    {
        
            
            #line default
            #line hidden
            
            #line 78 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
   Write(Html.ActionLinkButton("Import Status", MVC.Config.DocumentTemplate.ImportStatus()));

            
            #line default
            #line hidden
            
            #line 78 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                                                                                           
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 80 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
     if (Authorization.Has(Claims.Config.Show))
    {
        
            
            #line default
            #line hidden
            
            #line 82 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
   Write(Html.ActionLinkButton("Expression Browser", MVC.Config.DocumentTemplate.ExpressionBrowser()));

            
            #line default
            #line hidden
            
            #line 82 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                                                                                                     
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 84 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
     if (Authorization.HasAll(Claims.Config.DocumentTemplate.Create, Claims.Config.DocumentTemplate.Configure))
    {
        
            
            #line default
            #line hidden
            
            #line 86 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
   Write(Html.ActionLinkButton("Create Document Template", MVC.Config.DocumentTemplate.Create()));

            
            #line default
            #line hidden
            
            #line 86 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                                                                                                
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
