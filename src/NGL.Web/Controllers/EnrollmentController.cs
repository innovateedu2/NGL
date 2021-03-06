﻿using System.Globalization;
using System.Web.Mvc;
using NGL.Web.Data.Entities;
using NGL.Web.Data.Infrastructure;
using NGL.Web.Data.Repositories;
using NGL.Web.Infrastructure.Azure;
using NGL.Web.Infrastructure.Security;
using NGL.Web.Models;
using NGL.Web.Models.Enrollment;

namespace NGL.Web.Controllers
{
    public partial class EnrollmentController : Controller
    {
        private readonly IGenericRepository _repository;
        private readonly IMapper<CreateStudentModel, Student> _enrollmentMapper;
        private readonly IMapper<EnterProgramStatusModel, StudentProgramStatus> _programStatusMapper;
        private readonly IFileUploader _fileUploader;
        private readonly IMapper<AcademicDetailModel, StudentSchoolAssociation> _schoolAssociationMapper;
        private readonly IMapper<AcademicDetailModel, StudentAcademicDetail> _academicDetailMapper;
        private readonly IStudentRepository _studentRepository;

        public EnrollmentController(IGenericRepository repository, IMapper<CreateStudentModel, Student> enrollmentMapper,
                                                IMapper<EnterProgramStatusModel, StudentProgramStatus> programStatusMapper, 
                                                IMapper<AcademicDetailModel, StudentAcademicDetail> academicDetailMapper, 
                                                IFileUploader fileUploader,
                                                IMapper<AcademicDetailModel, 
                                                StudentSchoolAssociation> schoolAssociationMapper,
                                                IStudentRepository studentRepository)
        {
            _fileUploader = fileUploader;
            _schoolAssociationMapper = schoolAssociationMapper;
            _studentRepository = studentRepository;
            _academicDetailMapper = academicDetailMapper;
            _repository = repository;
            _enrollmentMapper = enrollmentMapper;
            _programStatusMapper = programStatusMapper;
        }

        // GET: /Enrollment/CreateStudent
        [AuthorizeFor(Resource = "enrollment", Operation = "create")]
        public virtual ActionResult CreateStudent()
        {
            return View(CreateStudentModel.New());
        }

        // POST: /Enrollment/CreateStudent
        [HttpPost]
        [AuthorizeFor(Resource = "enrollment", Operation = "create")]
        public virtual ActionResult CreateStudent(CreateStudentModel createStudentModel)
        {
            if (!ModelState.IsValid)
                return View(createStudentModel);

            var student = new Student();

            _enrollmentMapper.Map(createStudentModel, student);
            _repository.Add(student);
            _repository.Save();
            return RedirectToAction(MVC.Enrollment.EnterAcademicDetails(createStudentModel.StudentUsi.GetValueOrDefault()));
        }

        // GET: /Enrollment/EnterAcademicDetails/id
        [AuthorizeFor(Resource = "enrollment", Operation = "create")]
        public virtual ActionResult EnterAcademicDetails(int id)
        {
            var model = new AcademicDetailModel{StudentUsi = id};
            
            if (StudentDoesNotExist(id))
                return RedirectToAction(MVC.Error.General());

            return View(model);
        }

        private bool StudentDoesNotExist(int usi)
        {
            return _studentRepository.GetByUSI(usi) == null;
        }

        // POST: /Enrollment/EnterAcademicDetails/id
        [HttpPost]
        [AuthorizeFor(Resource = "enrollment", Operation = "create")]
        public virtual ActionResult EnterAcademicDetails(AcademicDetailModel academicDetailModel, int id)
        {
            if (!ModelState.IsValid)
                return View(academicDetailModel);

            var fileCategory = ((int)academicDetailModel.SchoolYear).ToString(CultureInfo.InvariantCulture);
            var performanceHistoryFileName = _fileUploader.Upload(academicDetailModel.PerformanceHistoryFile, id, fileCategory, "performanceHistory");
                    
            var studentAcademicDetail = _academicDetailMapper.Build(academicDetailModel,
                adm =>
                {
                    adm.StudentUSI = id;
                    adm.PerformanceHistoryFile = performanceHistoryFileName;
                });

            var studentSchoolAssociation = _schoolAssociationMapper.Build(academicDetailModel);

            _repository.Add(studentAcademicDetail);
            _repository.Add(studentSchoolAssociation);
            _repository.Save();
            return RedirectToAction(MVC.Enrollment.EnterProgramStatus(id));
        }

        // GET: /Enrollment/EnterProgramStatus/id
        [AuthorizeFor(Resource = "enrollment", Operation = "create")]
        public virtual ActionResult EnterProgramStatus(int id)
        {
            if (StudentDoesNotExist(id))
               return RedirectToAction(MVC.Error.General());
            return View();
        }

        // POST: /Enrollment/EnterProgramStatus/id
        [HttpPost]
        [AuthorizeFor(Resource = "enrollment", Operation = "create")]
        public virtual ActionResult EnterProgramStatus(EnterProgramStatusModel enterProgramStatusModel, int id)
        {
            if (!ModelState.IsValid)
                return View(enterProgramStatusModel);

            var specialEducationFileName = _fileUploader.Upload(enterProgramStatusModel.SpecialEducationFile, id, "ProgramStatus", "specialEducation");
            var testingAccomodationFileName = _fileUploader.Upload(enterProgramStatusModel.TestingAccommodationFile, id, "ProgramStatus", "testingAccomodation");
            var titleParticipationFileName = _fileUploader.Upload(enterProgramStatusModel.TitleParticipationFile, id, "ProgramStatus", "titleParticipation");
            var mcKinneyVentoFileName = _fileUploader.Upload(enterProgramStatusModel.McKinneyVentoFile, id, "ProgramStatus", "mcKinneyVento");

            var studentProgramStatus = _programStatusMapper.Build(enterProgramStatusModel,
                psm =>
                {
                    psm.StudentUSI = id;
                    psm.TitleParticipationFile = titleParticipationFileName;
                    psm.TestingAccommodationFile = testingAccomodationFileName;
                    psm.SpecialEducationFile = specialEducationFileName;
                    psm.McKinneyVentoFile = mcKinneyVentoFileName;
                });

            _repository.Add(studentProgramStatus);
            _repository.Save();
            return RedirectToAction(MVC.Student.Index(id));
        }
    }
}