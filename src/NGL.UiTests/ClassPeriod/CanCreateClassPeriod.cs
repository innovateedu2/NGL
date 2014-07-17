﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NGL.UiTests.Shared;
using NGL.Web.Models.ClassPeriod;
using Shouldly;
using TestStack.BDDfy;
using Xunit;

namespace NGL.UiTests.ClassPeriod
{
    [Story(
        AsA = "As a school admin",
        IWant = "I want to create periods",
        SoThat = "So that I know when different class sections are occuring")]
    public class CanCreateClassPeriod
    {
        private HomePage _homePage;
        private SchedulingPage _schedulingPage;
        private ClassPeriodCreatePage _classPeriodCreatePage;
        private CreateModel _classPeriodCreateModel;
        private ClassPeriodIndexPage _classPeriodIndexPage;

        public void GivenIHaveLoggedIn()
        {
            _homePage = Host.Instance
                   .NavigateToInitialPage<HomePage>()
                   .Login(ObjectMother.JohnSmith.ViewModel);   
        }

        public void AndGivenIAmOnTheCreateClassPeriodPage()
        {
            _schedulingPage = _homePage.TopMenu.GoToSchedulingPage();
            _classPeriodCreatePage = _schedulingPage.GoToClassPeriodIndexPage().GoToCreatePage();
        }

        public void WhenIHaveEnteredValidInputForAllFields()
        {
            _classPeriodCreateModel = new CreateModel
            {
                ClassPeriodName = ObjectMother.PeriodOne.ClassPeriodName
            };

            _classPeriodIndexPage = _classPeriodCreatePage.CreateClassPeriod(_classPeriodCreateModel);
        }

        public void ThenANewClassPeriodShouldBeDisplayedOnTheClassPeriodIndexPage()
        {
            bool classPeriodExists = _classPeriodIndexPage.ClassPeriodExists(_classPeriodCreateModel);
            classPeriodExists.ShouldBe(true);
        }

        [Fact]
        public void ShouldCreateClassPeriod()
        {
            this.BDDfy();
        }

    }
}