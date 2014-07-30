﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Elmah;
using NGL.Web.Data.Entities;
using NGL.Web.Data.Infrastructure;
using NGL.Web.Data.Queries;
using NGL.Web.ImageTools;
using NGL.Web.Infrastructure.Azure;
using NGL.Web.Models;
using NGL.Web.Models.Student;

namespace NGL.Web.Controllers
{
    public partial class StudentController : Controller
    {
        private readonly IGenericRepository _repository;
        private readonly IMapper<Student, ProfileModel> _studentToProfileModelMapper;
        private readonly IMapper<Student, IndexModel> _studentToStudentIndexModelMapper;
        private readonly AzureStorageUploader _fileUploader;
        private readonly AzureStorageDownloader _fileDownloader;

        public StudentController(IGenericRepository repository, IMapper<Student, ProfileModel> studentToProfileModelMapper,
                                                IMapper<Student, IndexModel> studentToStudentIndexModelMapper,
                                                AzureStorageUploader fileUploader, AzureStorageDownloader fileDownloader)
        {
            _repository = repository;
            _studentToProfileModelMapper = studentToProfileModelMapper;
            _studentToStudentIndexModelMapper = studentToStudentIndexModelMapper;
            _fileUploader = fileUploader;
            _fileDownloader = fileDownloader;
        }

        // GET: /Student/All
        public virtual ActionResult All()
        {
            IEnumerable<Student> students = _repository.GetAll<Student>();
            var models = new List<IndexModel>();

            foreach (var student in students)
            {
                var indexModel = new IndexModel();
                _studentToStudentIndexModelMapper.Map(student, indexModel);
                models.Add(indexModel);
            }

            return View(models);
        }

        //
        // GET: /Student/5
        public virtual ActionResult Index(int usi)
        {
            var student = _repository.Get(
                new StudentByUsiQuery(usi),
                s => s.StudentAddresses,
                s => s.StudentRaces,
                s => s.StudentLanguages,
                s => s.StudentLanguages.Select(l => l.StudentLanguageUses),
                s => s.StudentParentAssociations.Select(p => p.Parent),
                s => s.StudentParentAssociations.Select(p => p.Parent.ParentAddresses),
                s => s.StudentParentAssociations.Select(p => p.Parent.ParentTelephones),
                s => s.StudentParentAssociations.Select(p => p.Parent.ParentElectronicMails),
                s => s.StudentAcademicDetails
            );

            if (student == null)
                return HttpNotFound();

            var profileModel = _studentToProfileModelMapper.Build(student);
            return View(profileModel);
        }

        //
        // POST: /Student/UploadPhoto/5
        public virtual ActionResult UploadPhoto(HttpPostedFileBase profilePhoto, int usi)
        {
            try
            {
                var photoStream = Resizer.ScaleImage(profilePhoto.InputStream, 200, 250);
                var thumbNailStream = Resizer.ScaleImage(profilePhoto.InputStream, 50, 50);

                Upload(photoStream, usi + "/profilePhoto");
                Upload(thumbNailStream, usi + "/profileThumbnail");
            }
            catch (System.ArgumentException ex)
            {
                ErrorSignal.FromCurrentContext().Raise(ex);
            }
            return RedirectToAction(MVC.Student.Index(usi));
        }

        private void Upload(Stream file, string relativePath)
        {
            if (file != null)
                _fileUploader.Upload(file, ConfigManager.StudentBlobContainer, relativePath);
        }
    }
}
