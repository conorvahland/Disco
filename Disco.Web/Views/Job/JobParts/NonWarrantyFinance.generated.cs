﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Views.Job.JobParts
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
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job/JobParts/NonWarrantyFinance.cshtml")]
    public partial class NonWarrantyFinance : System.Web.Mvc.WebViewPage<Disco.Web.Models.Job.ShowModel>
    {
        public NonWarrantyFinance()
        {
        }
        public override void Execute()
        {
WriteLiteral("<table");

WriteLiteral(" id=\"jobNonWarrantyFinance\"");

WriteLiteral(">\r\n    <tr>\r\n        <th");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(">Accounting Charge Required\r\n        </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 7 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(CommonHelpers.FriendlyDate(Model.Job.JobMetaNonWarranty.AccountingChargeRequiredDate, "Not Required", "Job_JobMetaNonWarranty_AccountingChargeRequiredDate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"Job_JobMetaNonWarranty_AccountingChargeRequiredUser\"");

WriteLiteral(">");

            
            #line 8 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                       Write(string.IsNullOrEmpty(Model.Job.JobMetaNonWarranty.AccountingChargeRequiredUserId) ? string.Empty : string.Format("by {0}", Model.Job.JobMetaNonWarranty.AccountingChargeRequiredUser.ToString()));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("            ");

            
            #line 9 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(">Accounting Charge Added\r\n        </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 16 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(CommonHelpers.FriendlyDate(Model.Job.JobMetaNonWarranty.AccountingChargeAddedDate, "Not Added", "Job_JobMetaNonWarranty_AccountingChargeAddedDate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"Job_JobMetaNonWarranty_AccountingChargeAddedUser\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                    Write(string.IsNullOrEmpty(Model.Job.JobMetaNonWarranty.AccountingChargeAddedUserId) ? string.Empty : string.Format("by {0}", Model.Job.JobMetaNonWarranty.AccountingChargeAddedUser.ToString()));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("            ");

            
            #line 18 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(">Accounting Charge Paid\r\n        </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 25 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(CommonHelpers.FriendlyDate(Model.Job.JobMetaNonWarranty.AccountingChargePaidDate, "Not Paid", "Job_JobMetaNonWarranty_AccountingChargePaidDate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"Job_JobMetaNonWarranty_AccountingChargePaidUser\"");

WriteLiteral(">");

            
            #line 26 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                   Write(string.IsNullOrEmpty(Model.Job.JobMetaNonWarranty.AccountingChargePaidUserId) ? string.Empty : string.Format("by {0}", Model.Job.JobMetaNonWarranty.AccountingChargePaidUser.ToString()));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("            ");

            
            #line 27 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(">Purchase Order Raised\r\n        </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 34 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(CommonHelpers.FriendlyDate(Model.Job.JobMetaNonWarranty.PurchaseOrderRaisedDate, "Not Raised", "Job_JobMetaNonWarranty_PurchaseOrderRaisedDate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"Job_JobMetaNonWarranty_PurchaseOrderRaisedUser\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                  Write(string.IsNullOrEmpty(Model.Job.JobMetaNonWarranty.PurchaseOrderRaisedUserId) ? string.Empty : string.Format("by {0}", Model.Job.JobMetaNonWarranty.PurchaseOrderRaisedUser.ToString()));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("            ");

            
            #line 36 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th>Purchase Order Reference\r\n     " +
"   </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 43 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(Html.TextBoxFor(m => m.Job.JobMetaNonWarranty.PurchaseOrderReference));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 44 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(AjaxHelpers.AjaxSave());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 45 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n            <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
                $(function () {
                    var $purchaseOrderReference = $('#Job_JobMetaNonWarranty_PurchaseOrderReference');
                    var $ajaxSave = $purchaseOrderReference.next('.ajaxSave');
                    $purchaseOrderReference
                    .watermark('No Reference')
                    .focus(function () { $purchaseOrderReference.select() })
                    .keydown(function (e) {
                        $ajaxSave.show();
                        if (e.which == 13) {
                            $(this).blur();
                        }
                    }).blur(function () {
                        $ajaxSave.hide();
                    })
                    .change(function () {
                        $ajaxSave.hide();
                        $ajaxLoading = $ajaxSave.next('.ajaxLoading').show();
                        var data = { PurchaseOrderReference: $purchaseOrderReference.val() };
                        $.ajax({
                            url: '");

            
            #line 66 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                             Write(Url.Action(MVC.API.Job.UpdateNonWarrantyPurchaseOrderReference(Model.Job.Id, null)));

            
            #line default
            #line hidden
WriteLiteral(@"',
                            dataType: 'json',
                            data: data,
                            success: function (d) {
                                if (d == 'OK') {
                                    $ajaxLoading.hide().next('.ajaxOk').show().delay('fast').fadeOut('slow');
                                } else {
                                    $ajaxLoading.hide();
                                    alert('Unable to update purchase order reference: ' + d);
                                }
                            },
                            error: function (jqXHR, textStatus, errorThrown) {
                                alert('Unable to update purchase order reference: ' + textStatus);
                                $ajaxLoading.hide();
                            }
                        });
                    });
                });
            </script>
        </td>
    </tr>
    <tr>
        <th");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(">Purchase Order Sent\r\n        </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 91 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(CommonHelpers.FriendlyDate(Model.Job.JobMetaNonWarranty.PurchaseOrderSentDate, "Not Sent", "Job_JobMetaNonWarranty_PurchaseOrderSentDate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"Job_JobMetaNonWarranty_PurchaseOrderSentUser\"");

WriteLiteral(">");

            
            #line 92 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                Write(string.IsNullOrEmpty(Model.Job.JobMetaNonWarranty.PurchaseOrderSentUserId) ? string.Empty : string.Format("by {0}", Model.Job.JobMetaNonWarranty.PurchaseOrderSentUser.ToString()));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("            ");

            
            #line 93 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(">Invoice Received\r\n        </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 100 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(CommonHelpers.FriendlyDate(Model.Job.JobMetaNonWarranty.InvoiceReceivedDate, "Not Received", "Job_JobMetaNonWarranty_InvoiceReceivedDate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"Job_JobMetaNonWarranty_InvoiceReceivedUser\"");

WriteLiteral(">");

            
            #line 101 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                              Write(string.IsNullOrEmpty(Model.Job.JobMetaNonWarranty.InvoiceReceivedUserId) ? string.Empty : string.Format("by {0}", Model.Job.JobMetaNonWarranty.InvoiceReceivedUser.ToString()));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("            ");

            
            #line 102 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>\r\n<script>\r\n    (function(){\r\n        var bas" +
"eUpdateUrl = \'");

            
            #line 108 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                         Write(Url.Action(MVC.API.Job.Update(Model.Job.Id, null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n\r\n        var dialog, dialogForm, dialogHeader, dialogDateBox, dialogDateProp" +
"ertyNameBox;\r\n        var friendlyName, dateField, userField, updatePropertyName" +
", notSetDisplay, minDate, useAjax;\r\n\r\n        function dateDialogGet(){\r\n       " +
"     if (!dialog){\r\n                dialog = $(\'<div>\').attr({\'class\': \'dialog\'}" +
")\r\n                dialogForm = $(\'<form>\').attr({\'action\': baseUpdateUrl, \'meth" +
"od\': \'post\'}).appendTo(dialog);\r\n                var dialogBody = $(\'<p>\').appen" +
"dTo(dialogForm);\r\n                dialogHeader = $(\'<h3>\').attr(\'autofocus\', \'au" +
"tofocus\').appendTo(dialogBody);\r\n                dialogDatePropertyNameBox = $(\'" +
"<input>\').attr({\'type\': \'hidden\', \'name\': \'key\'}).appendTo(dialogBody);\r\n       " +
"         dialogDateBox = $(\'<input>\').attr({\'type\': \'datetime\', \'name\': \'value\'}" +
").css({\'display\': \'block\', \'margin-top\': 15, \'margin-left\': \'auto\', \'margin-righ" +
"t\': \'auto\' }).appendTo(dialogBody);\r\n                $(\'<input>\').attr({\'type\': " +
"\'hidden\', \'name\': \'redirect\'}).val(\'true\').appendTo(dialogBody);\r\n\r\n            " +
"    dialog.dialog({\r\n                    resizable: false,\r\n                    " +
"modal: true,\r\n                    autoOpen: false,\r\n                    buttons:" +
" {\r\n                        \"Update\": dateDialogUpdate,\r\n                       " +
" Cancel: function () {\r\n                            $(this).dialog(\"close\");\r\n  " +
"                      }\r\n                    },\r\n                    open: funct" +
"ion(){\r\n                        dialog.dialog(\'widget\').find(\'.ui-dialog-buttonp" +
"ane :tabbable:first\').focus();\r\n                    }\r\n                });\r\n    " +
"            dialogDateBox.datetimepicker({\r\n                    defaultDate: new" +
" Date(),\r\n                    ampm: true,\r\n                    changeYear: true," +
"\r\n                    changeMonth: true,\r\n                    dateFormat: \'yy/mm" +
"/dd\',\r\n                });\r\n            }\r\n            return dialog;\r\n        }" +
"\r\n\r\n        function dateDialogUpdate(){\r\n            var dateValue = dialogDate" +
"Box.val();\r\n\r\n            if (useAjax){\r\n                // Use Ajax\r\n          " +
"      var $dateField, $userField;\r\n                $dateField = $(\'#\' + dateFiel" +
"d);\r\n                if (userField)\r\n                    $userField = $(\'#\' + us" +
"erField);\r\n\r\n                dialog.dialog(\"close\");\r\n\r\n                var $aja" +
"xLoading = ($userField ? $userField.next(\'.ajaxLoading\') : $dateField.next(\'.aja" +
"xLoading\')).show();\r\n\r\n                var data = {\r\n                    key: up" +
"datePropertyName,\r\n                    value: dateValue\r\n                };\r\n   " +
"             $.getJSON(baseUpdateUrl, data, function (response, result) {\r\n     " +
"               if (result != \'success\' || response.Result != \'OK\') {\r\n          " +
"              alert(\'Unable to change \' + friendlyName + \' Date:\\n\' + response);" +
"\r\n                        $ajaxLoading.hide();\r\n                    } else {\r\n  " +
"                      if (response.DateTimeFull){\r\n                            $" +
"dateField.attr(\'data-datetimeformatted\', response.DateTimeJavascript)\r\n         " +
"                       .attr(\'data-discodatetime\', response.DateTimeSortable)\r\n " +
"                               .attr(\'title\', response.DateTimeFull)\r\n          " +
"                      .text(response.DateTimeFriendly);\r\n                       " +
" }else{\r\n                            $dateField.attr(\'data-datetimeformatted\', \'" +
"\')\r\n                                .attr(\'data-discodatetime\', \'-1\')\r\n         " +
"                       .attr(\'title\', notSetDisplay)\r\n                          " +
"      .text(notSetDisplay);\r\n                        }\r\n                        " +
"if ($userField)\r\n                            $userField.text(\'by \' + response.Us" +
"erDescription);\r\n                        $ajaxLoading.hide().next(\'.ajaxOk\').sho" +
"w().delay(\'fast\').fadeOut(\'slow\');\r\n                    }\r\n                })\r\n " +
"           }else{\r\n                // Post Form & Redirect\r\n                dial" +
"og.dialog(\"disable\");\r\n                dialog.dialog(\"option\", \"buttons\", null);" +
"\r\n\r\n                dialogDatePropertyNameBox.val(updatePropertyName);\r\n\r\n      " +
"          dialogForm.submit();\r\n            }\r\n        }\r\n\r\n        function dat" +
"eDialogOpen(FriendlyName, DateField, UserField, UpdatePropertyName, NotSetDispla" +
"y, MinDate, UseAjax){\r\n            friendlyName = FriendlyName;\r\n            dat" +
"eField = DateField;\r\n            userField = UserField;\r\n            updatePrope" +
"rtyName = UpdatePropertyName;\r\n            notSetDisplay = NotSetDisplay;\r\n     " +
"       minDate = MinDate;\r\n            useAjax = UseAjax;\r\n\r\n            var d =" +
" dateDialogGet();\r\n\r\n            d.dialog(\'option\', \'title\', friendlyName);\r\n   " +
"         dialogHeader.text(friendlyName + \' Date\');\r\n\r\n            var dfVal = $" +
"(\'#\' + DateField).attr(\'data-datetimeformatted\');\r\n\r\n            if (dfVal)\r\n   " +
"             dialogDateBox.datetimepicker(\'setDate\', new Date(dfVal));\r\n        " +
"    else\r\n                dialogDateBox.datetimepicker(\'setDate\', new Date());\r\n" +
"\r\n            if (MinDate)\r\n                dialogDateBox.datetimepicker(\'option" +
"\', \'minDate\', MinDate);\r\n            else\r\n                dialogDateBox.datetim" +
"epicker(\'option\', \'minDate\', null);\r\n\r\n            d.dialog(\'open\');\r\n        }\r" +
"\n\r\n        function dateDialogCreateUpdater(FriendlyName, DateField, UserField, " +
"UpdatePropertyName, NotSetDisplay, MinDate, UseAjax){\r\n            $(\'<a>\').attr" +
"({href: \'#\', \'class\': \'button small\', style: \'margin-right: 5px;\'}).text(\'Update" +
"\').click(function(event){\r\n                event.preventDefault();\r\n            " +
"    dateDialogOpen(FriendlyName, DateField, UserField, UpdatePropertyName, NotSe" +
"tDisplay, MinDate, UseAjax);\r\n            }).insertBefore(\'#\' + DateField);\r\n   " +
"     }\r\n\r\n        if (!document.DiscoFunctions)\r\n            document.DiscoFunct" +
"ions = {};\r\n        if (!document.DiscoFunctions.DateDialogCreateUpdater)\r\n     " +
"       document.DiscoFunctions.DateDialogCreateUpdater = dateDialogCreateUpdater" +
";\r\n    })();\r\n    $(function(){\r\n        var jobOpenDate = \'");

            
            #line 240 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                       Write(Model.Job.OpenedDate.ToJavascriptDateTime());

            
            #line default
            #line hidden
WriteLiteral("\';\r\n\r\n        document.DiscoFunctions.DateDialogCreateUpdater(\'Accounting Charge " +
"Required\', \'Job_JobMetaNonWarranty_AccountingChargeRequiredDate\', \'Job_JobMetaNo" +
"nWarranty_AccountingChargeRequiredUser\', \'NonWarrantyAccountingChargeRequired\', " +
"\'Not Required\', jobOpenDate, false);\r\n        document.DiscoFunctions.DateDialog" +
"CreateUpdater(\'Accounting Charge Added\', \'Job_JobMetaNonWarranty_AccountingCharg" +
"eAddedDate\', \'Job_JobMetaNonWarranty_AccountingChargeAddedUser\', \'NonWarrantyAcc" +
"ountingChargeAdded\', \'Not Added\', jobOpenDate, false);\r\n        document.DiscoFu" +
"nctions.DateDialogCreateUpdater(\'Accounting Charge Paid\', \'Job_JobMetaNonWarrant" +
"y_AccountingChargePaidDate\', \'Job_JobMetaNonWarranty_AccountingChargePaidUser\', " +
"\'NonWarrantyAccountingChargePaid\', \'Not Paid\', jobOpenDate, false);\r\n        doc" +
"ument.DiscoFunctions.DateDialogCreateUpdater(\'Purchase Order Raised\', \'Job_JobMe" +
"taNonWarranty_PurchaseOrderRaisedDate\', \'Job_JobMetaNonWarranty_PurchaseOrderRai" +
"sedUser\', \'NonWarrantyPurchaseOrderRaised\', \'Not Raised\', jobOpenDate, true);\r\n " +
"       document.DiscoFunctions.DateDialogCreateUpdater(\'Purchase Order Sent\', \'J" +
"ob_JobMetaNonWarranty_PurchaseOrderSentDate\', \'Job_JobMetaNonWarranty_PurchaseOr" +
"derSentUser\', \'NonWarrantyPurchaseOrderSent\', \'Not Sent\', jobOpenDate, true);\r\n " +
"       document.DiscoFunctions.DateDialogCreateUpdater(\'Invoice Received\', \'Job_" +
"JobMetaNonWarranty_InvoiceReceivedDate\', \'Job_JobMetaNonWarranty_InvoiceReceived" +
"User\', \'NonWarrantyInvoiceReceived\', \'Not Received\', jobOpenDate, true);\r\n    })" +
";\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
