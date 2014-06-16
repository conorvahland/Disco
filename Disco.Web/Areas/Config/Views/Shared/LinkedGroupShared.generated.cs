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

namespace Disco.Web.Areas.Config.Views.Shared
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/Shared/LinkedGroupShared.cshtml")]
    public partial class LinkedGroupShared : Disco.Services.Web.WebViewPage<dynamic>
    {
        public LinkedGroupShared()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" id=\"Config_LinkedGroup_Dialog\"");

WriteLiteral(" title=\"Linked Group\"");

WriteLiteral(" class=\"dialog\"");

WriteLiteral(">\r\n    <h3");

WriteLiteral(" id=\"Config_LinkedGroup_Title\"");

WriteLiteral("></h3>\r\n    <div");

WriteLiteral(" class=\"infoBox error\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"fa-p\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"fa fa-exclamation-circle\"");

WriteLiteral(@"></i><strong>Warning:</strong> This group will be managed by Disco ICT.<br />
            Any <strong>existing members will be removed from the group</strong>, and it will be automatically synchronized with related members.
        </p>
    </div>
    <form");

WriteLiteral(" action=\"#\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"Config_LinkedGroup_Id\"");

WriteLiteral(">Linked Group: </label>\r\n            <input");

WriteLiteral(" id=\"Config_LinkedGroup_Id\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" name=\"GroupId\"");

WriteLiteral(@" />
        </div>
    </form>
</div>
<script>
    $(function () {
        var dialog;
        var dialogGroupId;
        var dialogTitle;

        function showDialog(groupId, updateUrl, title) {
            if (dialog == null) {
                dialog = $('#Config_LinkedGroup_Dialog').dialog({
                    width: 450,
                    resizable: false,
                    modal: true,
                    autoOpen: false
                });

                dialogGroupId = $('#Config_LinkedGroup_Id');
                dialogGroupId.focus(function () { $(this).select(); });
                dialogGroupId.autocomplete({
                    source: '");

            
            #line 34 "..\..\Areas\Config\Views\Shared\LinkedGroupShared.cshtml"
                         Write(Url.Action(MVC.API.System.SearchGroupSubjects()));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                    minLength: 2,\r\n                    select: function (e, u" +
"i) {\r\n                        dialogGroupId.val(ui.item.Id);\r\n                  " +
"      return false;\r\n                    }\r\n                }).data(\'ui-autocomp" +
"lete\')._renderItem = function (ul, item) {\r\n                    return $(\"<li>\")" +
"\r\n                        .data(\"item.autocomplete\", item)\r\n                    " +
"    .append(\"<a><strong>\" + item.Name + \"</strong><br>\" + item.Id + \" (\" + item." +
"Type + \")</a>\")\r\n                        .appendTo(ul);\r\n                };\r\n\r\n " +
"               dialogTitle = $(\'#Config_LinkedGroup_Title\');\r\n            }\r\n\r\n " +
"           var dialogButtons = {};\r\n            if (!!groupId) {\r\n              " +
"  dialogButtons[\'Remove Link\'] = function () {\r\n                    $(this).dial" +
"og(\'disable\');\r\n                    dialogGroupId.val(\'\');\r\n                    " +
"dialogGroupId.closest(\'form\').attr(\'action\', updateUrl).submit();\r\n             " +
"   }\r\n            }\r\n            dialogButtons[(!!groupId ? \'Save Changes\' : \'Li" +
"nk Group\')] = function () {\r\n                if (!dialogGroupId.val()) {\r\n      " +
"              alert(\'A Linked Group must be specified\');\r\n                    re" +
"turn;\r\n                }\r\n                $(this).dialog(\'disable\');\r\n          " +
"      dialogGroupId.closest(\'form\').attr(\'action\', updateUrl).submit();\r\n       " +
"     }\r\n            dialogButtons[\'Cancel\'] = function () {\r\n                $(t" +
"his).dialog(\'close\');\r\n            };\r\n\r\n            dialogGroupId.val(groupId);" +
"\r\n            dialogTitle.text(title);\r\n            dialog.dialog(\'option\', \'but" +
"tons\', dialogButtons);\r\n            dialog.dialog(\'option\', \'title\', \'Linked Gro" +
"up: \' + title);\r\n            dialog.dialog(\'open\');\r\n        }\r\n\r\n        $(docu" +
"ment).on(\'click\', \'.Config_LinkedGroup_LinkButton\', function () {\r\n            $" +
"this = $(this);\r\n\r\n            var configuredGroupId = $this.attr(\'data-linkedgr" +
"oupid\');\r\n            var description = $this.attr(\'data-linkedroupdescription\')" +
";\r\n            var updateUrl = $this.attr(\'data-linkedroupupdateurl\');\r\n\r\n      " +
"      showDialog(configuredGroupId, updateUrl, description);\r\n\r\n            retu" +
"rn false;\r\n        });\r\n    });\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
