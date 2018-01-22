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
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Services;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/DocumentTemplate/_ExpressionsTable.cshtml")]
    public partial class _ExpressionsTable : Disco.Services.Web.WebViewPage<IEnumerable<Disco.Services.Expressions.Expression>>
    {
        public _ExpressionsTable()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
  
    Authorization.Require(Claims.Config.DocumentTemplate.Show);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"expressionsTable\"");

WriteLiteral(">\r\n");

            
            #line 6 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
    
            
            #line default
            #line hidden
            
            #line 6 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
     if (Model.Count() > 0)
    { 

            
            #line default
            #line hidden
WriteLiteral("        <table");

WriteLiteral(" class=\"expressionsTable\"");

WriteLiteral(@">
            <tr>
                <th>
                    Name
                </th>
                <th>
                    Expression
                </th>
                <th>
                    Errors Allowed
                </th>
            </tr>
");

            
            #line 20 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
             foreach (var expression in Model.Where(m => m.IsDynamic))
            {
                var expressionParts = expression.Where(e => e.IsDynamic).ToArray();

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td");

WriteAttribute("rowspan", Tuple.Create(" rowspan=\"", 725), Tuple.Create("\"", 760)
            
            #line 24 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
, Tuple.Create(Tuple.Create("", 735), Tuple.Create<System.Object, System.Int32>(expressionParts.Length
            
            #line default
            #line hidden
, 735), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 25 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                   Write(expression.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 27 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 27 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                     if (expressionParts[0].ParseError)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td");

WriteLiteral(" class=\"parseError\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 30 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                       Write(expressionParts[0].Source.ToMultilineString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <div");

WriteLiteral(" class=\"code\"");

WriteLiteral(">\r\n                                <strong>Expression Compilation Error:</strong>" +
"<br />\r\n");

WriteLiteral("                                ");

            
            #line 33 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                           Write(expressionParts[0].ParseErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n");

            
            #line 36 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                    }
                    else
                    { 

            
            #line default
            #line hidden
WriteLiteral("                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 40 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                       Write(expressionParts[0].Source.ToMultilineString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n");

            
            #line 42 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 44 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                    Write(expressionParts[0].ErrorsAllowed ? "Yes" : "No");

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");

            
            #line 47 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                    for (int expressionIndex = 1; expressionIndex < expressionParts.Length; expressionIndex++)
                    {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n");

            
            #line 50 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 50 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                     if (expressionParts[expressionIndex].ParseError)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td");

WriteLiteral(" class=\"parseError\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 53 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                       Write(expressionParts[expressionIndex].Source.ToMultilineString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <div");

WriteLiteral(" class=\"code\"");

WriteLiteral(">\r\n                                <strong>Expression Compilation Error:</strong>" +
"<br />\r\n");

WriteLiteral("                                ");

            
            #line 56 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                           Write(expressionParts[expressionIndex].ParseErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n");

            
            #line 59 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                    }
                    else
                    { 

            
            #line default
            #line hidden
WriteLiteral("                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 63 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                       Write(expressionParts[expressionIndex].Source.ToMultilineString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n");

            
            #line 65 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 67 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                    Write(expressionParts[expressionIndex].ErrorsAllowed ? "Yes" : "No");

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");

            
            #line 70 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
                    }
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n");

            
            #line 73 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
    }
    else
    { 

            
            #line default
            #line hidden
WriteLiteral("        <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Expressions Found</span>\r\n");

            
            #line 77 "..\..\Areas\Config\Views\DocumentTemplate\_ExpressionsTable.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
