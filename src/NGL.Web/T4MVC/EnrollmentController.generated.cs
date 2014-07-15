// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
using NGL.Web.Models.Enrollment;
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
    public partial class EnrollmentController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected EnrollmentController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult EnterProgramStatus()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EnterProgramStatus);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public EnrollmentController Actions { get { return MVC.Enrollment; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Enrollment";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Enrollment";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string CreateStudent = "CreateStudent";
            public readonly string EnterProgramStatus = "EnterProgramStatus";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string CreateStudent = "CreateStudent";
            public const string EnterProgramStatus = "EnterProgramStatus";
        }


        static readonly ActionParamsClass_CreateStudent s_params_CreateStudent = new ActionParamsClass_CreateStudent();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CreateStudent CreateStudentParams { get { return s_params_CreateStudent; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CreateStudent
        {
            public readonly string createStudentModel = "createStudentModel";
        }
        static readonly ActionParamsClass_EnterProgramStatus s_params_EnterProgramStatus = new ActionParamsClass_EnterProgramStatus();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EnterProgramStatus EnterProgramStatusParams { get { return s_params_EnterProgramStatus; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EnterProgramStatus
        {
            public readonly string id = "id";
            public readonly string enterProgramStatusModel = "enterProgramStatusModel";
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
                public readonly string CreateStudent = "CreateStudent";
                public readonly string EnterProgramStatus = "EnterProgramStatus";
            }
            public readonly string CreateStudent = "~/Views/Enrollment/CreateStudent.cshtml";
            public readonly string EnterProgramStatus = "~/Views/Enrollment/EnterProgramStatus.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_EnrollmentController : NGL.Web.Controllers.EnrollmentController
    {
        public T4MVC_EnrollmentController() : base(Dummy.Instance) { }

        [NonAction]
        partial void CreateStudentOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult CreateStudent()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateStudent);
            CreateStudentOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void CreateStudentOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, NGL.Web.Models.Enrollment.CreateStudentModel createStudentModel);
        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, CreateStudentModel createStudentModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult CreateStudent(CreateStudentModel createStudentModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateStudent);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "createStudentModel", createStudentModel);
            CreateStudentOverride(callInfo, createStudentModel);
            return callInfo;
        }

        [NonAction]
        partial void EnterProgramStatusOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult EnterProgramStatus(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EnterProgramStatus);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            EnterProgramStatusOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void EnterProgramStatusOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, NGL.Web.Models.Enrollment.EnterProgramStatusModel enterProgramStatusModel, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult EnterProgramStatus(NGL.Web.Models.Enrollment.EnterProgramStatusModel enterProgramStatusModel, int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EnterProgramStatus);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "enterProgramStatusModel", enterProgramStatusModel);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            EnterProgramStatusOverride(callInfo, enterProgramStatusModel, id);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
