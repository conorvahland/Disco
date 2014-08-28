// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Disco.Web.Areas.API.Controllers
{
    public partial class BootstrapperController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public BootstrapperController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected BootstrapperController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult MacSshUsername()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.MacSshUsername);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult MacSshPassword()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.MacSshPassword);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public BootstrapperController Actions { get { return MVC.API.Bootstrapper; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "API";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Bootstrapper";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Bootstrapper";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string MacSshUsername = "MacSshUsername";
            public readonly string MacSshPassword = "MacSshPassword";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string MacSshUsername = "MacSshUsername";
            public const string MacSshPassword = "MacSshPassword";
        }


        static readonly ActionParamsClass_MacSshUsername s_params_MacSshUsername = new ActionParamsClass_MacSshUsername();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_MacSshUsername MacSshUsernameParams { get { return s_params_MacSshUsername; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_MacSshUsername
        {
            public readonly string MacSshUsername = "MacSshUsername";
        }
        static readonly ActionParamsClass_MacSshPassword s_params_MacSshPassword = new ActionParamsClass_MacSshPassword();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_MacSshPassword MacSshPasswordParams { get { return s_params_MacSshPassword; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_MacSshPassword
        {
            public readonly string MacSshPassword = "MacSshPassword";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_BootstrapperController : Disco.Web.Areas.API.Controllers.BootstrapperController
    {
        public T4MVC_BootstrapperController() : base(Dummy.Instance) { }

        [NonAction]
        partial void MacSshUsernameOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string MacSshUsername);

        [NonAction]
        public override System.Web.Mvc.ActionResult MacSshUsername(string MacSshUsername)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.MacSshUsername);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "MacSshUsername", MacSshUsername);
            MacSshUsernameOverride(callInfo, MacSshUsername);
            return callInfo;
        }

        [NonAction]
        partial void MacSshPasswordOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string MacSshPassword);

        [NonAction]
        public override System.Web.Mvc.ActionResult MacSshPassword(string MacSshPassword)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.MacSshPassword);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "MacSshPassword", MacSshPassword);
            MacSshPasswordOverride(callInfo, MacSshPassword);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591