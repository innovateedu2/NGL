﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moq;
using NGL.Tests.Builders;
using NGL.Web.Controllers;
using NGL.Web.Data.Infrastructure;
using NGL.Web.Data.Repositories;
using NGL.Web.Models;
using NGL.Web.Models.Course;
using Xunit;
using CreateModel = NGL.Web.Models.Course.CreateModel;
using IndexModel = NGL.Web.Models.Course.IndexModel;

namespace NGL.Tests.Course
{
    public class CourseControllerTests
    {
        private Mock<IGenericRepository> _mockGenericRepository;
        private Mock<IMapper<Web.Data.Entities.Course, IndexModel>> _mockCourseToIndexModelMapper;
        private Mock<IMapper<CreateModel, Web.Data.Entities.Course>> _mockCreateModelToCourseMapper;
        private Mock<IMapper<Web.Data.Entities.ParentCourse, ParentCourseListItemModel>> _mockParentCourseToParentCourseListItemModelMapper;
        private Mock<ICourseRepository> _mockCourseRepository;

        [Fact]
        public void IndexShouldReturnListOfIndexModels()
        {
            var controller = SetUpController();

            var result = (ViewResult) controller.Index();

            Assert.Equal(result.Model, new List<IndexModel>());
        }
        private CourseController SetUpController()
        {
            _mockGenericRepository = new Mock<IGenericRepository>();
            _mockCourseToIndexModelMapper = new Mock<IMapper<Web.Data.Entities.Course, IndexModel>>();
            _mockCreateModelToCourseMapper = new Mock<IMapper<CreateModel, Web.Data.Entities.Course>>();
            _mockParentCourseToParentCourseListItemModelMapper =
                new Mock<IMapper<Web.Data.Entities.ParentCourse, ParentCourseListItemModel>>();
            _mockCourseRepository = new Mock<ICourseRepository>();
            var controller = new CourseController(_mockGenericRepository.Object,
                _mockCourseToIndexModelMapper.Object,
                _mockCreateModelToCourseMapper.Object,
                _mockParentCourseToParentCourseListItemModelMapper.Object,
                _mockCourseRepository.Object);
            return controller;
        }

        [Fact]
        public void IndexShouldReturnListModelsForEachCourse()
        {
            var controller = SetUpController();
            var courses = SetUpCourses();

            var indexModels = (List<IndexModel>) ((ViewResult)controller.Index()).Model;

            _mockCourseToIndexModelMapper.Verify(mapper => mapper.Map(courses.ElementAt(0), It.IsAny<IndexModel>()));
            _mockCourseToIndexModelMapper.Verify(mapper => mapper.Map(courses.ElementAt(1), It.IsAny<IndexModel>()));
            Assert.Equal(indexModels.Count, 2);
        }

        private IEnumerable<Web.Data.Entities.Course> SetUpCourses()
        {
            var courses = new List<Web.Data.Entities.Course>();
            var course1 = new CourseBuilder().Build();
            var course2 = new CourseBuilder().Build();
            courses.Add(course1);
            courses.Add(course2);
            _mockGenericRepository.Setup(repo => repo.GetAll<Web.Data.Entities.Course>()).Returns(courses);
            return courses;
        }

        [Fact]
        public void GetCreateShouldReturnCreateModelWithParentCourses()
        {
            //todo: refactoring GetParentCourseList into repo for easier testing
            var controller = SetUpController();

            var parentCourses = new List<Web.Data.Entities.ParentCourse>();
            parentCourses.Add(new ParentCourseBuilder().Build());
            parentCourses.Add(new ParentCourseBuilder().Build());
            _mockGenericRepository.Setup(repo => repo.GetAll<Web.Data.Entities.ParentCourse>()).Returns(parentCourses);

            var result = (CreateModel) ((ViewResult) controller.Create()).Model;
            
            Assert.Equal(2, result.ParentCourseList.Count);
        }

        [Fact(Skip = "RedirectToAction fails in build.cmd although test passes in VS")]
        public void PostCreateShouldSaveCourse()
        {
            var controller = SetUpController();

            var createModel = new CreateModel();
            var courseToSave = new CourseBuilder().Build();
            _mockCreateModelToCourseMapper.Setup(mapper => mapper.Build(createModel)).Returns(courseToSave);

            controller.Create(createModel);

            _mockGenericRepository.Verify(repo => repo.Add(courseToSave));
            _mockGenericRepository.Verify(repo => repo.Save());
        }

        [Fact(Skip="RedirectToAction fails in build.cmd although test passes in VS")]
        public void PostCreateShouldRedirectToCourseIndex()
        {
            var controller = SetUpController();

            var createModel = new CreateModel();
            var courseToSave = new CourseBuilder().Build();
            _mockCreateModelToCourseMapper.Setup(mapper => mapper.Build(createModel)).Returns(courseToSave);

            var result = (RedirectToRouteResult) controller.Create(createModel);

            Assert.Equal("Course", result.RouteValues["Controller"]);
            Assert.Equal("Index", result.RouteValues["Action"]);
        }

        [Fact]
        public void PostCreateShouldReturnItselfWhenModelStateIsInvalid()
        {
            var controller = SetUpController();
            var createModel = new CreateModel();
            controller.ModelState.AddModelError("error", "some error in the model state");

            var result = (ViewResult) controller.Create(createModel);

            Assert.Equal(createModel, result.Model);
            Assert.Equal("", result.ViewName);
        }
    }
}
