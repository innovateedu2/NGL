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
namespace NGL.Web.Controllers
{
    public partial class ParentCourseGradeController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ParentCourseGradeController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult ExportCsv()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ExportCsv);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ParentCourseGradeController Actions { get { return MVC.ParentCourseGrade; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "ParentCourseGrade";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "ParentCourseGrade";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Get = "Get";
            public readonly string Edit = "Edit";
            public readonly string ExportCsv = "ExportCsv";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Get = "Get";
            public const string Edit = "Edit";
            public const string ExportCsv = "ExportCsv";
        }


        static readonly ActionParamsClass_Get s_params_Get = new ActionParamsClass_Get();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Get GetParams { get { return s_params_Get; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Get
        {
            public readonly string sessionId = "sessionId";
            public readonly string parentCourseId = "parentCourseId";
        }
        static readonly ActionParamsClass_Edit s_params_Edit = new ActionParamsClass_Edit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Edit EditParams { get { return s_params_Edit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Edit
        {
            public readonly string sessionId = "sessionId";
            public readonly string parentCourseId = "parentCourseId";
            public readonly string parentCourseGradesModel = "parentCourseGradesModel";
        }
        static readonly ActionParamsClass_ExportCsv s_params_ExportCsv = new ActionParamsClass_ExportCsv();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ExportCsv ExportCsvParams { get { return s_params_ExportCsv; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ExportCsv
        {
            public readonly string sessionId = "sessionId";
            public readonly string parentCourseId = "parentCourseId";
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
                public readonly string Edit = "Edit";
                public readonly string Index = "Index";
            }
            public readonly string Edit = "~/Views/ParentCourseGrade/Edit.cshtml";
            public readonly string Index = "~/Views/ParentCourseGrade/Index.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_ParentCourseGradeController : NGL.Web.Controllers.ParentCourseGradeController
    {
        public T4MVC_ParentCourseGradeController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GetOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? sessionId, System.Guid? parentCourseId);

        [NonAction]
        public override System.Web.Mvc.ActionResult Get(int? sessionId, System.Guid? parentCourseId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Get);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "sessionId", sessionId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "parentCourseId", parentCourseId);
            GetOverride(callInfo, sessionId, parentCourseId);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? sessionId, System.Guid? parentCourseId);

        [NonAction]
        public override System.Web.Mvc.ActionResult Edit(int? sessionId, System.Guid? parentCourseId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "sessionId", sessionId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "parentCourseId", parentCourseId);
            EditOverride(callInfo, sessionId, parentCourseId);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, NGL.Web.Models.ParentCourse.ParentCourseGradesModel parentCourseGradesModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult Edit(NGL.Web.Models.ParentCourse.ParentCourseGradesModel parentCourseGradesModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "parentCourseGradesModel", parentCourseGradesModel);
            EditOverride(callInfo, parentCourseGradesModel);
            return callInfo;
        }

        [NonAction]
        partial void ExportCsvOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? sessionId, System.Guid? parentCourseId);

        [NonAction]
        public override System.Web.Mvc.ActionResult ExportCsv(int? sessionId, System.Guid? parentCourseId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ExportCsv);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "sessionId", sessionId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "parentCourseId", parentCourseId);
            ExportCsvOverride(callInfo, sessionId, parentCourseId);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
