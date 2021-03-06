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
    public partial class StudentController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected StudentController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UploadPhoto()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UploadPhoto);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult EditBiographicalInfo()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.EditBiographicalInfo);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult EditStudentName()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.EditStudentName);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult EditHomeAddress()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.EditHomeAddress);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult EditParentInfo()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.EditParentInfo);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult EditProgramStatus()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditProgramStatus);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult EditAcademicDetails()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditAcademicDetails);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult ValidateEditedAcademicDetails()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.ValidateEditedAcademicDetails);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public StudentController Actions { get { return MVC.Student; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Student";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Student";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string All = "All";
            public readonly string Reports = "Reports";
            public readonly string Index = "Index";
            public readonly string UploadPhoto = "UploadPhoto";
            public readonly string EditBiographicalInfo = "EditBiographicalInfo";
            public readonly string EditStudentName = "EditStudentName";
            public readonly string EditHomeAddress = "EditHomeAddress";
            public readonly string EditParentInfo = "EditParentInfo";
            public readonly string EditProgramStatus = "EditProgramStatus";
            public readonly string EditAcademicDetails = "EditAcademicDetails";
            public readonly string ValidateEditedAcademicDetails = "ValidateEditedAcademicDetails";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string All = "All";
            public const string Reports = "Reports";
            public const string Index = "Index";
            public const string UploadPhoto = "UploadPhoto";
            public const string EditBiographicalInfo = "EditBiographicalInfo";
            public const string EditStudentName = "EditStudentName";
            public const string EditHomeAddress = "EditHomeAddress";
            public const string EditParentInfo = "EditParentInfo";
            public const string EditProgramStatus = "EditProgramStatus";
            public const string EditAcademicDetails = "EditAcademicDetails";
            public const string ValidateEditedAcademicDetails = "ValidateEditedAcademicDetails";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string usi = "usi";
        }
        static readonly ActionParamsClass_UploadPhoto s_params_UploadPhoto = new ActionParamsClass_UploadPhoto();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UploadPhoto UploadPhotoParams { get { return s_params_UploadPhoto; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UploadPhoto
        {
            public readonly string profilePhoto = "profilePhoto";
            public readonly string usi = "usi";
        }
        static readonly ActionParamsClass_EditBiographicalInfo s_params_EditBiographicalInfo = new ActionParamsClass_EditBiographicalInfo();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditBiographicalInfo EditBiographicalInfoParams { get { return s_params_EditBiographicalInfo; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditBiographicalInfo
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_EditStudentName s_params_EditStudentName = new ActionParamsClass_EditStudentName();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditStudentName EditStudentNameParams { get { return s_params_EditStudentName; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditStudentName
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_EditHomeAddress s_params_EditHomeAddress = new ActionParamsClass_EditHomeAddress();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditHomeAddress EditHomeAddressParams { get { return s_params_EditHomeAddress; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditHomeAddress
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_EditParentInfo s_params_EditParentInfo = new ActionParamsClass_EditParentInfo();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditParentInfo EditParentInfoParams { get { return s_params_EditParentInfo; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditParentInfo
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_EditProgramStatus s_params_EditProgramStatus = new ActionParamsClass_EditProgramStatus();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditProgramStatus EditProgramStatusParams { get { return s_params_EditProgramStatus; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditProgramStatus
        {
            public readonly string studentUsi = "studentUsi";
            public readonly string programStatus = "programStatus";
        }
        static readonly ActionParamsClass_EditAcademicDetails s_params_EditAcademicDetails = new ActionParamsClass_EditAcademicDetails();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditAcademicDetails EditAcademicDetailsParams { get { return s_params_EditAcademicDetails; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditAcademicDetails
        {
            public readonly string studentUSI = "studentUSI";
            public readonly string academicDetail = "academicDetail";
        }
        static readonly ActionParamsClass_ValidateEditedAcademicDetails s_params_ValidateEditedAcademicDetails = new ActionParamsClass_ValidateEditedAcademicDetails();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ValidateEditedAcademicDetails ValidateEditedAcademicDetailsParams { get { return s_params_ValidateEditedAcademicDetails; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ValidateEditedAcademicDetails
        {
            public readonly string AcademicDetail = "AcademicDetail";
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
                public readonly string AcademicDetails = "AcademicDetails";
                public readonly string All = "All";
                public readonly string BiographicalInformation = "BiographicalInformation";
                public readonly string Delete = "Delete";
                public readonly string FirstParentPartial = "FirstParentPartial";
                public readonly string HomeAddress = "HomeAddress";
                public readonly string Index = "Index";
                public readonly string ParentPartial = "ParentPartial";
                public readonly string ProgramStatus = "ProgramStatus";
                public readonly string ReadonlyParentInfoPartial = "ReadonlyParentInfoPartial";
                public readonly string Reports = "Reports";
                public readonly string SecondParentPartial = "SecondParentPartial";
                public readonly string StudentName = "StudentName";
            }
            public readonly string AcademicDetails = "~/Views/Student/AcademicDetails.cshtml";
            public readonly string All = "~/Views/Student/All.cshtml";
            public readonly string BiographicalInformation = "~/Views/Student/BiographicalInformation.cshtml";
            public readonly string Delete = "~/Views/Student/Delete.cshtml";
            public readonly string FirstParentPartial = "~/Views/Student/FirstParentPartial.cshtml";
            public readonly string HomeAddress = "~/Views/Student/HomeAddress.cshtml";
            public readonly string Index = "~/Views/Student/Index.cshtml";
            public readonly string ParentPartial = "~/Views/Student/ParentPartial.cshtml";
            public readonly string ProgramStatus = "~/Views/Student/ProgramStatus.cshtml";
            public readonly string ReadonlyParentInfoPartial = "~/Views/Student/ReadonlyParentInfoPartial.cshtml";
            public readonly string Reports = "~/Views/Student/Reports.cshtml";
            public readonly string SecondParentPartial = "~/Views/Student/SecondParentPartial.cshtml";
            public readonly string StudentName = "~/Views/Student/StudentName.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_StudentController : NGL.Web.Controllers.StudentController
    {
        public T4MVC_StudentController() : base(Dummy.Instance) { }

        [NonAction]
        partial void AllOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult All()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.All);
            AllOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ReportsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Reports()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Reports);
            ReportsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int usi);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(int usi)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "usi", usi);
            IndexOverride(callInfo, usi);
            return callInfo;
        }

        [NonAction]
        partial void UploadPhotoOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Web.HttpPostedFileBase profilePhoto, int usi);

        [NonAction]
        public override System.Web.Mvc.ActionResult UploadPhoto(System.Web.HttpPostedFileBase profilePhoto, int usi)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UploadPhoto);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "profilePhoto", profilePhoto);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "usi", usi);
            UploadPhotoOverride(callInfo, profilePhoto, usi);
            return callInfo;
        }

        [NonAction]
        partial void EditBiographicalInfoOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, NGL.Web.Models.Student.EditableStudentBiographicalInfoModel model);

        [NonAction]
        public override System.Web.Mvc.JsonResult EditBiographicalInfo(NGL.Web.Models.Student.EditableStudentBiographicalInfoModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.EditBiographicalInfo);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            EditBiographicalInfoOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void EditStudentNameOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, NGL.Web.Models.Student.NameModel model);

        [NonAction]
        public override System.Web.Mvc.JsonResult EditStudentName(NGL.Web.Models.Student.NameModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.EditStudentName);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            EditStudentNameOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void EditHomeAddressOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, NGL.Web.Models.Student.HomeAddressModel model);

        [NonAction]
        public override System.Web.Mvc.JsonResult EditHomeAddress(NGL.Web.Models.Student.HomeAddressModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.EditHomeAddress);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            EditHomeAddressOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void EditParentInfoOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, NGL.Web.Models.Student.EditProfileParentModel model);

        [NonAction]
        public override System.Web.Mvc.JsonResult EditParentInfo(NGL.Web.Models.Student.EditProfileParentModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.EditParentInfo);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            EditParentInfoOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void EditProgramStatusOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int studentUsi, NGL.Web.Models.Enrollment.EnterProgramStatusModel programStatus);

        [NonAction]
        public override System.Web.Mvc.ActionResult EditProgramStatus(int studentUsi, NGL.Web.Models.Enrollment.EnterProgramStatusModel programStatus)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditProgramStatus);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "studentUsi", studentUsi);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "programStatus", programStatus);
            EditProgramStatusOverride(callInfo, studentUsi, programStatus);
            return callInfo;
        }

        [NonAction]
        partial void EditAcademicDetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int studentUSI, NGL.Web.Models.Enrollment.EditAcademicDetailModel academicDetail);

        [NonAction]
        public override System.Web.Mvc.ActionResult EditAcademicDetails(int studentUSI, NGL.Web.Models.Enrollment.EditAcademicDetailModel academicDetail)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditAcademicDetails);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "studentUSI", studentUSI);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "academicDetail", academicDetail);
            EditAcademicDetailsOverride(callInfo, studentUSI, academicDetail);
            return callInfo;
        }

        [NonAction]
        partial void ValidateEditedAcademicDetailsOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, NGL.Web.Models.Enrollment.EditAcademicDetailModel AcademicDetail);

        [NonAction]
        public override System.Web.Mvc.JsonResult ValidateEditedAcademicDetails(NGL.Web.Models.Enrollment.EditAcademicDetailModel AcademicDetail)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.ValidateEditedAcademicDetails);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "AcademicDetail", AcademicDetail);
            ValidateEditedAcademicDetailsOverride(callInfo, AcademicDetail);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
