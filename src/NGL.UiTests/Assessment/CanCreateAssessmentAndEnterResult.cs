﻿using NGL.Tests.Builders;
using NGL.UiTests.Shared;
using NGL.Web.Models.Assessment;
using Shouldly;
using TestStack.BDDfy;
using Xunit;

namespace NGL.UiTests.Assessment
{
    [Story(
        AsA = "As a teacher",
        IWant = "I want to create a formative assessment for a specific section",
        SoThat = "So that I can track student's progress over time"
        )]
    public class CanCreateAssessmentAndEnterResult
    {
        private HomePage _homePage;
        private AssessmentCreatePage _assessmentCreatePage;
        private CreateModel _createAssessmentModel;
        private AssessmentIndexPage _assessmentIndexPage;
        private AssessmentResultsPage _resultsPage;

        public void HaveLoggedIn()
        {
            _homePage = Host.Instance
                .NavigateToInitialPage<HomePage>()
                .Login(ObjectMother.UserJohnSmith.ViewModel);
        }

        public void AmOnTheCreateAssessmentPage()
        {
            _assessmentCreatePage = _homePage.TopMenu.GoToAssessmentIndexPage().GoToCreatePage();
        }

        public void HaveEnteredValidInputForAllFields()
        {
            _createAssessmentModel = new CreateAssessmentModelBuilder().Build();
            _assessmentIndexPage = _assessmentCreatePage.CreateAssessment(_createAssessmentModel);
        }

        public void ANewAssessmentShouldBeDisplayedOnTheAssessmentIndexPage()
        {
            var assessmentExists = _assessmentIndexPage.AssessmentExists(_createAssessmentModel);
            assessmentExists.ShouldBe(true);
        }

        public void GoToTheResultsPageAndFillInValidResults()
        {
            _resultsPage = _assessmentIndexPage.GoToResultsPage();
            _assessmentIndexPage = _resultsPage.EnterResultsForFirstStudent("96");
        }

        public void GoBackToTheResultsPage()
        {
            _resultsPage = _assessmentIndexPage.GoToResultsPage();
        }

        public void TheNewAssessmentResultsShouldBeSaved()
        {
            _resultsPage.ResultsExistForFirstStudent("96").ShouldBe(true);
        }

        [Fact]
        public void ShouldCreateAssessment()
        {
            this.Given(_ => HaveLoggedIn())
                .And(_ => AmOnTheCreateAssessmentPage())
                .When(_ => HaveEnteredValidInputForAllFields())
                .Then(_ => ANewAssessmentShouldBeDisplayedOnTheAssessmentIndexPage())
                .When(_ => GoToTheResultsPageAndFillInValidResults())
                .And(_ => GoBackToTheResultsPage())
                .Then(_ => TheNewAssessmentResultsShouldBeSaved())
                .BDDfy();
        }
    }
}
