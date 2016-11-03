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

namespace Disco.Web.Views.Device.DeviceParts
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Device/DeviceParts/_Resources.cshtml")]
    public partial class _Resources : Disco.Services.Web.WebViewPage<Disco.Web.Models.Device.ShowModel>
    {
        public _Resources()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
  
    Authorization.Require(Claims.Device.ShowAttachments);

    var canAddAttachments = Authorization.Has(Claims.Device.Actions.AddAttachments);
    var canRemoveAnyAttachments = Authorization.Has(Claims.Device.Actions.RemoveAnyAttachments);
    var canRemoveOwnAttachments = Authorization.Has(Claims.Device.Actions.RemoveOwnAttachments);

    Html.BundleDeferred("~/Style/Shadowbox");
    Html.BundleDeferred("~/ClientScripts/Modules/Shadowbox");
    Html.BundleDeferred("~/ClientScripts/Modules/jQuery-SignalR");

    if (canAddAttachments)
    {
        Html.BundleDeferred("~/ClientScripts/Modules/Disco-AttachmentUploader");
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"DeviceDetailTab-Resources\"");

WriteLiteral(" class=\"DevicePart\"");

WriteLiteral(">\r\n    <table");

WriteLiteral(" id=\"deviceShowResources\"");

WriteLiteral(">\r\n        <tr>\r\n            <td");

WriteLiteral(" id=\"AttachmentsContainer\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" id=\"Attachments\"");

WriteAttribute("class", Tuple.Create(" class=\"", 888), Tuple.Create("\"", 963)
            
            #line 22 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
, Tuple.Create(Tuple.Create("", 896), Tuple.Create<System.Object, System.Int32>(canAddAttachments ? "canAddAttachments" : "cannotAddAttachments"
            
            #line default
            #line hidden
, 896), false)
);

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"Disco-AttachmentUpload-DropTarget\"");

WriteLiteral(">\r\n                        <h2>Drop Attachments Here</h2>\r\n                    </" +
"div>\r\n                    <div");

WriteLiteral(" class=\"attachmentOutput\"");

WriteLiteral(">\r\n");

            
            #line 27 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                         if (Model.Device.DeviceAttachments != null)
                        {
                            foreach (var da in Model.Device.DeviceAttachments)
                            {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1410), Tuple.Create("\"", 1470)
            
            #line 31 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
, Tuple.Create(Tuple.Create("", 1417), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.Device.AttachmentDownload(da.Id))
            
            #line default
            #line hidden
, 1417), false)
);

WriteLiteral(" data-attachmentid=\"");

            
            #line 31 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                                          Write(da.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-mimetype=\"");

            
            #line 31 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                                                                 Write(da.MimeType);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" class=\"icon\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1580), Tuple.Create("\"", 1600)
            
            #line 32 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
, Tuple.Create(Tuple.Create("", 1588), Tuple.Create<System.Object, System.Int32>(da.Filename
            
            #line default
            #line hidden
, 1588), false)
);

WriteLiteral(">\r\n                                    <img");

WriteLiteral(" alt=\"Attachment Thumbnail\"");

WriteAttribute("src", Tuple.Create(" src=\"", 1671), Tuple.Create("\"", 1733)
            
            #line 33 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
, Tuple.Create(Tuple.Create("", 1677), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.Device.AttachmentThumbnail(da.Id))
            
            #line default
            #line hidden
, 1677), false)
);

WriteLiteral(" /></span>\r\n                                <span");

WriteLiteral(" class=\"comments\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1800), Tuple.Create("\"", 1820)
            
            #line 34 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
, Tuple.Create(Tuple.Create("", 1808), Tuple.Create<System.Object, System.Int32>(da.Comments
            
            #line default
            #line hidden
, 1808), false)
);

WriteLiteral(">\r\n");

            
            #line 35 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                      if (!string.IsNullOrEmpty(da.DocumentTemplateId))
                                      { 
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                   Write(da.DocumentTemplate.Description);

            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                        }
                                      else
                                      { 
            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                   Write(da.Comments);

            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                     }
            
            #line default
            #line hidden
WriteLiteral("\r\n                                </span><span");

WriteLiteral(" class=\"author\"");

WriteLiteral(">");

            
            #line 39 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                       Write(da.TechUser.ToString());

            
            #line default
            #line hidden
WriteLiteral("</span>");

            
            #line 39 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                           if (canRemoveAnyAttachments || (canRemoveOwnAttachments && da.TechUserId.Equals(CurrentUser.UserId, StringComparison.OrdinalIgnoreCase)))
                                                                                          {
            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"remove fa fa-times-circle\"");

WriteLiteral("></span>");

            
            #line 40 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                                                                                       }
            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"timestamp\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2494), Tuple.Create("\"", 2532)
            
            #line 40 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                                       , Tuple.Create(Tuple.Create("", 2502), Tuple.Create<System.Object, System.Int32>(da.Timestamp.ToFullDateTime()
            
            #line default
            #line hidden
, 2502), false)
);

WriteLiteral(" data-livestamp=\"");

            
            #line 40 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                                                                                                                                                                  Write(da.Timestamp.ToUnixEpoc());

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 40 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                                                                                                                                                                                              Write(da.Timestamp.ToFullDateTime());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </a>   \r\n");

            
            #line 42 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                            }
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n");

            
            #line 45 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                     if (canAddAttachments)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"Disco-AttachmentUpload-Progress\"");

WriteLiteral("></div>\r\n");

WriteLiteral("                        <div");

WriteLiteral(" class=\"attachmentInput clearfix\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"action upload fa fa-upload disabled\"");

WriteLiteral(" title=\"Attach File\"");

WriteLiteral("></span><span");

WriteLiteral(" class=\"action photo fa fa-camera disabled\"");

WriteLiteral(" title=\"Capture Image\"");

WriteLiteral("></span>\r\n                        </div>\r\n");

            
            #line 51 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
                        Shadowbox.init({
                            skipSetup: true,
                            modal: true
                        });
                        $(function () {
                            var $Attachments = $('#Attachments');
                            var $attachmentOutput = $Attachments.find('.attachmentOutput');
                            var $attachmentDownloadHost;

                            var $dialogRemoveAttachment = null;

                            // Connect to Hub
                            var hub = $.connection.deviceUpdates;

                            // Map Functions
                            hub.client.addAttachment = onAddAttachment;
                            hub.client.removeAttachment = onRemoveAttachment;

                            $.connection.hub.qs = { DeviceSerialNumber: '");

            
            #line 71 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                     Write(Model.Device.SerialNumber);

            
            #line default
            #line hidden
WriteLiteral("\' };\r\n                            $.connection.hub.error(onHubFailed);\r\n         " +
"                   $.connection.hub.disconnected(onHubFailed);\r\n\r\n              " +
"              $.connection.hub.reconnecting(function () {\r\n                     " +
"           $(\'#AttachmentsContainer\').find(\'span.action\').addClass(\'disabled\');\r" +
"\n                            });\r\n                            $.connection.hub.r" +
"econnected(function () {\r\n                                $(\'#AttachmentsContain" +
"er\').find(\'span.action\').removeClass(\'disabled\');\r\n                            }" +
");\r\n\r\n                            // Start Connection\r\n                         " +
"   $.connection.hub.start(function () {\r\n                                $(\'#Att" +
"achmentsContainer\').find(\'span.action\').removeClass(\'disabled\');\r\n              " +
"              }).fail(onHubFailed);\r\n\r\n                            function onHu" +
"bFailed(error) {\r\n                                // Disable UI\r\n               " +
"                 $(\'#AttachmentsContainer\').find(\'span.action\').addClass(\'disabl" +
"ed\');\r\n\r\n                                // Show Dialog Message\r\n               " +
"                 if ($(\'.disconnected-dialog\').length == 0) {\r\n                 " +
"                   $(\'<div>\')\r\n                                        .addClass" +
"(\'dialog disconnected-dialog\')\r\n                                        .html(\'<" +
"h3><span class=\"fa-stack fa-lg\"><i class=\"fa fa-wifi fa-stack-1x\"></i><i class=\"" +
"fa fa-ban fa-stack-2x error\"></i></span>Disconnected from the Disco ICT Server</" +
"h3><div>This page is not receiving live updates. Please ensure you are connected" +
" to the server, then refresh this page to enable features.</div>\')\r\n            " +
"                            .dialog({\r\n                                         " +
"   resizable: false,\r\n                                            title: \'Discon" +
"nected\',\r\n                                            width: 400,\r\n             " +
"                               modal: true,\r\n                                   " +
"         buttons: {\r\n                                                \'Refresh No" +
"w\': function () {\r\n                                                    $(this).d" +
"ialog(\'option\', \'buttons\', null);\r\n                                             " +
"       window.location.reload(true);\r\n                                          " +
"      },\r\n                                                \'Close\': function () {" +
"\r\n                                                    $(this).dialog(\'destroy\');" +
"\r\n                                                }\r\n                           " +
"                 }\r\n                                        });\r\n               " +
"                 }\r\n                            }\r\n\r\n                           " +
" function onAddAttachment(id, quick) {\r\n                                var data" +
" = { id: id };\r\n                                $.ajax({\r\n                      " +
"              url: \'");

            
            #line 117 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                     Write(Url.Action(MVC.API.Device.Attachment()));

            
            #line default
            #line hidden
WriteLiteral(@"',
                                    dataType: 'json',
                                    data: data,
                                    success: function (d) {
                                        if (d.Result == 'OK') {
                                            var a = d.Attachment;
");

            
            #line 123 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 123 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                         if (canRemoveAnyAttachments)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                        ");

WriteLiteral("buildAttachment(a, true, quick);");

WriteLiteral("\r\n");

            
            #line 126 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                        }
                                        else if (canRemoveOwnAttachments)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                        ");

WriteLiteral("buildAttachment(a, (a.AuthorId === \'");

            
            #line 129 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                              Write(CurrentUser.UserId);

            
            #line default
            #line hidden
WriteLiteral("\'), quick);");

WriteLiteral("\r\n");

            
            #line 130 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                        ");

WriteLiteral("buildAttachment(a, false, quick);");

WriteLiteral("\r\n");

            
            #line 134 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral(@"                                        } else {
                                            alert('Unable to add attachment: ' + d.Result);
                                        }
                                    },
                                    error: function (jqXHR, textStatus, errorThrown) {
                                        alert('Unable to add attachment: ' + textStatus);
                                    }
                                });
                            }

                            function buildAttachment(a, canRemove, quick) {
                                var t = '<a><span class=""icon""><img alt=""Attachment Thumbnail"" /></span><span class=""comments""></span><span class=""author""></span>';
                                if (canRemove)
                                    t += '<span class=""remove fa fa-times-circle""></span>';
                                t += '<span class=""timestamp""></span></a>';

                                var e = $(t);

                                e.attr('data-attachmentid', a.Id).attr('data-mimetype', a.MimeType).attr('href', '");

            
            #line 153 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                                              Write(Url.Action(MVC.API.Device.AttachmentDownload()));

            
            #line default
            #line hidden
WriteLiteral(@"/' + a.Id);
                                e.find('.comments').text(a.Description);
                                e.find('.author').text(a.Author);
                                e.find('.timestamp').text(a.TimestampFull).attr('title', a.TimestampFull).livestamp(a.TimestampUnixEpoc);
                                if (canRemove)
                                    e.find('.remove').click(removeAttachment);
                                if (!quick)
                                    e.hide();
                                $attachmentOutput.append(e);
                                onUpdate();
                                if (!quick)
                                    e.show('slow');
                                if (a.MimeType.toLowerCase().indexOf('image/') == 0)
                                    e.shadowbox({ gallery: 'attachments', player: 'img', title: a.Description });
                                else
                                    e.click(onDownload);

                                // Add Thumbnail
                                var buildThumbnail = function () {
                                    var retryCount = 0;
                                    var img = e.find('.icon img');

                                    var setThumbnailUrl = function () {
                                        img.attr('src', '");

            
            #line 176 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                     Write(Url.Action(MVC.API.Device.AttachmentThumbnail()));

            
            #line default
            #line hidden
WriteLiteral("/\' + a.Id + \'?v=\' + retryCount);\r\n                                    };\r\n       " +
"                             img.on(\'error\', function () {\r\n                    " +
"                    img.addClass(\'loading\');\r\n                                  " +
"      retryCount++;\r\n                                        if (retryCount < 6)" +
"\r\n                                            window.setTimeout(setThumbnailUrl," +
" retryCount * 250);\r\n                                    });\r\n                  " +
"                  img.on(\'load\', function () {\r\n                                " +
"        img.removeClass(\'loading\');\r\n                                    });\r\n  " +
"                                  window.setTimeout(setThumbnailUrl, 100);\r\n    " +
"                            };\r\n                                buildThumbnail()" +
";\r\n                            }\r\n\r\n                            function onRemov" +
"eAttachment(id) {\r\n                                var a = $attachmentOutput.fin" +
"d(\'a[data-attachmentid=\' + id + \']\');\r\n\r\n                                a.hide(" +
"300).delay(300).queue(function () {\r\n                                    var $th" +
"is = $(this);\r\n                                    if ($this.attr(\'data-mimetype" +
"\').toLowerCase().indexOf(\'image/\') == 0)\r\n                                      " +
"  Shadowbox.removeCache(this);\r\n                                    $this.find(\'" +
".timestamp\').livestamp(\'destroy\');\r\n                                    $this.re" +
"move();\r\n                                    onUpdate();\r\n                      " +
"          });\r\n                            }\r\n\r\n                            func" +
"tion onDownload() {\r\n                                var $this = $(this);\r\n     " +
"                           var url = $this.attr(\'href\');\r\n\r\n                    " +
"            if ($.connection && $.connection.hub && $.connection.hub.transport &" +
"&\r\n                                                    $.connection.hub.transpor" +
"t.name == \'foreverFrame\') {\r\n                                    // SignalR acti" +
"ve with foreverFrame transport - use popup window\r\n                             " +
"       window.open(url, \'_blank\', \'height=150,width=250,location=no,menubar=no,r" +
"esizable=no,scrollbars=no,status=no,toolbar=no\');\r\n                             " +
"   } else {\r\n                                    // use iFrame\r\n                " +
"                    if (!$attachmentDownloadHost) {\r\n                           " +
"             $attachmentDownloadHost = $(\'<iframe>\')\r\n                          " +
"                  .attr({ \'src\': url, \'title\': \'Attachment Download Host\' })\r\n  " +
"                                          .addClass(\'hidden\')\r\n                 " +
"                           .appendTo(\'body\')\r\n                                  " +
"          .contents();\r\n                                    } else {\r\n          " +
"                              $attachmentDownloadHost[0].location.href = url;\r\n " +
"                                   }\r\n                                }\r\n\r\n     " +
"                           return false;\r\n                            }\r\n\r\n     " +
"                       function onUpdate() {\r\n                                va" +
"r attachmentCount = $attachmentOutput.children(\'a\').length;\r\n                   " +
"             var tabHeading = \'Attachments [\' + attachmentCount + \']\';\r\n        " +
"                        $(\'#DeviceDetailTab-ResourcesLink\').text(tabHeading);\r\n " +
"                           }\r\n\r\n");

            
            #line 235 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 235 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                         if (canAddAttachments)
                        {
            
            #line default
            #line hidden
WriteLiteral("\r\n                            //#region Add Attachments\r\n                        " +
"    var attachmentUploader = new document.Disco.AttachmentUploader(\r\n           " +
"                     \'");

            
            #line 239 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                             Write(Url.Action(MVC.API.Device.AttachmentUpload(Model.Device.SerialNumber, null)));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                            $Attachments.find(\'.Disco-AttachmentUpload-DropTa" +
"rget\'),\r\n                            $Attachments.find(\'.Disco-AttachmentUpload-" +
"Progress\'));\r\n\r\n                            var $attachmentInput = $Attachments." +
"find(\'.attachmentInput\');\r\n                            $attachmentInput.find(\'.p" +
"hoto\').click(function () {\r\n                                if ($(this).hasClass" +
"(\'disabled\'))\r\n                                    alert(\'Disconnected from the " +
"Disco ICT Server, please refresh this page and try again\');\r\n                   " +
"             else\r\n                                    attachmentUploader.upload" +
"Image();\r\n                            });\r\n                            $attachme" +
"ntInput.find(\'.upload\').click(function () {\r\n                                if " +
"($(this).hasClass(\'disabled\'))\r\n                                    alert(\'Disco" +
"nnected from the Disco ICT Server, please refresh this page and try again\');\r\n  " +
"                              else\r\n                                    attachme" +
"ntUploader.uploadFiles();\r\n                            });\r\n\r\n                  " +
"          var resourcesTab;\r\n                            $(document).on(\'dragove" +
"r\', function () {\r\n                                if (!resourcesTab) {\r\n       " +
"                             var tabs = $Attachments.closest(\'.ui-tabs\');\r\n     " +
"                               resourcesTab = {\r\n                               " +
"         tabs: tabs,\r\n                                        resourcesIndex: ta" +
"bs.children(\'ul.ui-tabs-nav\').find(\'a[href=\"#DeviceDetailTab-Resources\"]\').close" +
"st(\'li\').index()\r\n                                    };\r\n                      " +
"          }\r\n                                var selectedIndex = resourcesTab.ta" +
"bs.tabs(\'option\', \'active\');\r\n                                if (resourcesTab.r" +
"esourcesIndex !== selectedIndex)\r\n                                    resourcesT" +
"ab.tabs.tabs(\'option\', \'active\', resourcesTab.resourcesIndex);\r\n                " +
"            });\r\n                            //#endregion\r\n                     " +
"       ");

            
            #line 271 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                   }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 272 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                         if (canRemoveAnyAttachments || canRemoveOwnAttachments)
                        {
            
            #line default
            #line hidden
WriteLiteral(@"
                            //#region Remove Attachments
                            $attachmentOutput.find('span.remove').click(removeAttachment);

                            function removeAttachment() {
                                $this = $(this).closest('a');

                                var data = { id: $this.attr('data-attachmentid') };

                                if (!$dialogRemoveAttachment) {
                                    $dialogRemoveAttachment = $('#dialogRemoveAttachment').dialog({
                                        resizable: false,
                                        height: 140,
                                        modal: true,
                                        autoOpen: false
                                    });
                                }

                                $dialogRemoveAttachment.dialog(""enable"");
                                $dialogRemoveAttachment.dialog('option', 'buttons', {
                                    ""Remove"": function () {
                                        $dialogRemoveAttachment.dialog(""disable"");
                                        $dialogRemoveAttachment.dialog(""option"", ""buttons"", null);
                                        $.ajax({
                                            url: '");

            
            #line 297 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                             Write(Url.Action(MVC.API.Device.AttachmentRemove()));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                                            dataType: \'json\',\r\n              " +
"                              data: data,\r\n                                     " +
"       success: function (d) {\r\n                                                " +
"if (d == \'OK\') {\r\n                                                    // Do noth" +
"ing, await SignalR notification\r\n                                               " +
" } else {\r\n                                                    alert(\'Unable to " +
"remove attachment: \' + d);\r\n                                                }\r\n " +
"                                               $dialogRemoveAttachment.dialog(\"c" +
"lose\");\r\n                                            },\r\n                       " +
"                     error: function (jqXHR, textStatus, errorThrown) {\r\n       " +
"                                         alert(\'Unable to remove attachment: \' +" +
" textStatus);\r\n                                                $dialogRemoveAtta" +
"chment.dialog(\"close\");\r\n                                            }\r\n        " +
"                                });\r\n                                    },\r\n   " +
"                                 Cancel: function () {\r\n                        " +
"                $dialogRemoveAttachment.dialog(\"close\");\r\n                      " +
"              }\r\n                                });\r\n\r\n                        " +
"        $dialogRemoveAttachment.dialog(\'open\');\r\n\r\n                             " +
"   return false;\r\n                            }\r\n                            //#" +
"endregion\r\n                        ");

            
            #line 324 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                               }

            
            #line default
            #line hidden
WriteLiteral(@"
                            $attachmentOutput.children('a').each(function () {
                                $this = $(this);
                                if ($this.attr('data-mimetype').toLowerCase().indexOf('image/') == 0)
                                    $this.shadowbox({ gallery: 'attachments', player: 'img', title: $this.find('.comments').text() });
                                else
                                    $this.click(onDownload);
                            });
                        });
                    </script>
                </div>
            </td>
        </tr>
    </table>
    <div");

WriteLiteral(" id=\"dialogRemoveAttachment\"");

WriteLiteral(" class=\"dialog\"");

WriteLiteral(" title=\"Remove this Attachment?\"");

WriteLiteral(">\r\n        <p>\r\n            <i");

WriteLiteral(" class=\"fa fa-exclamation-triangle fa-lg\"");

WriteLiteral("></i>&nbsp;Are you sure?\r\n        </p>\r\n    </div>\r\n    <script>\r\n        $(\'#Dev" +
"iceDetailTabItems\').append(\'<li><a href=\"#DeviceDetailTab-Resources\" id=\"DeviceD" +
"etailTab-ResourcesLink\">Attachments [");

            
            #line 345 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                                                                Write(Model.Device.DeviceAttachments == null ? 0 : Model.Device.DeviceAttachments.Count);

            
            #line default
            #line hidden
WriteLiteral("]</a></li>\');\r\n    </script>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
