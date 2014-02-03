﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Areas.Config.Views.JobQueue
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
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/JobQueue/Index.cshtml")]
    public partial class Index : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.JobQueue.IndexModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
  
    Authorization.RequireAll(Claims.Config.JobQueue.Create, Claims.Config.JobQueue.Configure);
    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Job Queues", MVC.Config.JobQueue.Index(null));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"Config_JobQueues_Index\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
     if (Model.Tokens.Count == 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 450px; padding: 100px 0;\"");

WriteLiteral(">\r\n            <h2>No job queues are configured</h2>\r\n        </div>  \r\n");

            
            #line 12 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <table");

WriteLiteral(" class=\"tableData\"");

WriteLiteral(">\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Priority<" +
"/th>\r\n                <th>Linked Groups/Users</th>\r\n            </tr>\r\n");

            
            #line 21 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 21 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
             foreach (var item in Model.Tokens)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 852), Tuple.Create("\"", 915)
            
            #line 25 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
, Tuple.Create(Tuple.Create("", 859), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Config.JobQueue.Index(item.JobQueue.Id))
            
            #line default
            #line hidden
, 859), false)
);

WriteLiteral(">\r\n                            <i");

WriteAttribute("class", Tuple.Create(" class=\"", 949), Tuple.Create("\"", 1020)
, Tuple.Create(Tuple.Create("", 957), Tuple.Create("fa", 957), true)
, Tuple.Create(Tuple.Create(" ", 959), Tuple.Create("fa-", 960), true)
            
            #line 26 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
, Tuple.Create(Tuple.Create("", 963), Tuple.Create<System.Object, System.Int32>(item.JobQueue.Icon
            
            #line default
            #line hidden
, 963), false)
, Tuple.Create(Tuple.Create(" ", 984), Tuple.Create("fa-lg", 985), true)
, Tuple.Create(Tuple.Create(" ", 990), Tuple.Create("d-", 991), true)
            
            #line 26 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
, Tuple.Create(Tuple.Create("", 993), Tuple.Create<System.Object, System.Int32>(item.JobQueue.IconColour
            
            #line default
            #line hidden
, 993), false)
);

WriteLiteral("></i>\r\n");

WriteLiteral("                            ");

            
            #line 27 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                       Write(item.JobQueue.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </td>\r\n                    <t" +
"d>\r\n                        <i");

WriteAttribute("class", Tuple.Create(" class=\"", 1186), Tuple.Create("\"", 1254)
, Tuple.Create(Tuple.Create("", 1194), Tuple.Create("fa", 1194), true)
, Tuple.Create(Tuple.Create(" ", 1196), Tuple.Create("d-priority-", 1197), true)
            
            #line 31 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1208), Tuple.Create<System.Object, System.Int32>(item.JobQueue.Priority.ToString().ToLower()
            
            #line default
            #line hidden
, 1208), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 1255), Tuple.Create("\"", 1308)
            
            #line 31 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                        , Tuple.Create(Tuple.Create("", 1263), Tuple.Create<System.Object, System.Int32>(item.JobQueue.Priority.ToString()
            
            #line default
            #line hidden
, 1263), false)
, Tuple.Create(Tuple.Create(" ", 1299), Tuple.Create("Priority", 1300), true)
);

WriteLiteral("></i>\r\n                    </td>\r\n                    <td>\r\n");

            
            #line 34 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 34 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                         if (item.SubjectIds.Count == 0)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">&lt;None&gt;</span>\r\n");

            
            #line 37 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                        }
                        else
                        {
                            
            
            #line default
            #line hidden
            
            #line 40 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                        Write(string.Join(", ", item.SubjectIds.OrderBy(i => i)));

            
            #line default
            #line hidden
            
            #line 40 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                                                                                 
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                </tr>\r\n");

            
            #line 44 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n");

            
            #line 46 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 48 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
   Write(Html.ActionLinkButton("Create Job Queue", MVC.Config.JobQueue.Create()));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
