﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Views.Update
{
    using Disco.Services.Web;
    using System.Web.Mvc;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Update/_ViewStart.cshtml")]
    public partial class _ViewStart : System.Web.Mvc.ViewStartPage
    {
        public _ViewStart()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Update\_ViewStart.cshtml"
  
    ViewContext.ViewData.Add("IsMaintenanceMode", true);
    Layout = MVC.Shared.Views._PublicLayout;
    Html.BundleDeferred("~/Style/AppMaintenance");

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
