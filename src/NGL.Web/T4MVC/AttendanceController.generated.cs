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
    public partial class AttendanceController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected AttendanceController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult GetStudents()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetStudents);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Save()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Save);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public AttendanceController Actions { get { return MVC.Attendance; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Attendance";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Attendance";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Take = "Take";
            public readonly string GetStudents = "GetStudents";
            public readonly string Save = "Save";
            public readonly string ClearAllFlags = "ClearAllFlags";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Take = "Take";
            public const string GetStudents = "GetStudents";
            public const string Save = "Save";
            public const string ClearAllFlags = "ClearAllFlags";
        }


        static readonly ActionParamsClass_GetStudents s_params_GetStudents = new ActionParamsClass_GetStudents();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetStudents GetStudentsParams { get { return s_params_GetStudents; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetStudents
        {
            public readonly string takeAttendanceModel = "takeAttendanceModel";
        }
        static readonly ActionParamsClass_Save s_params_Save = new ActionParamsClass_Save();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Save SaveParams { get { return s_params_Save; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Save
        {
            public readonly string takeAttendanceModel = "takeAttendanceModel";
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
                public readonly string Take = "Take";
            }
            public readonly string Take = "~/Views/Attendance/Take.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_AttendanceController : NGL.Web.Controllers.AttendanceController
    {
        public T4MVC_AttendanceController() : base(Dummy.Instance) { }

        [NonAction]
        partial void TakeOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Take()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Take);
            TakeOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GetStudentsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, NGL.Web.Models.Attendance.TakeAttendanceModel takeAttendanceModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetStudents(NGL.Web.Models.Attendance.TakeAttendanceModel takeAttendanceModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetStudents);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "takeAttendanceModel", takeAttendanceModel);
            GetStudentsOverride(callInfo, takeAttendanceModel);
            return callInfo;
        }

        [NonAction]
        partial void SaveOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, NGL.Web.Models.Attendance.TakeAttendanceModel takeAttendanceModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult Save(NGL.Web.Models.Attendance.TakeAttendanceModel takeAttendanceModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Save);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "takeAttendanceModel", takeAttendanceModel);
            SaveOverride(callInfo, takeAttendanceModel);
            return callInfo;
        }

        [NonAction]
        partial void ClearAllFlagsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ClearAllFlags()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ClearAllFlags);
            ClearAllFlagsOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
