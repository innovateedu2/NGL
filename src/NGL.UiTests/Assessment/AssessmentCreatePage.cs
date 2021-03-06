﻿using Humanizer;
using NGL.Web.Models.Assessment;
using OpenQA.Selenium;
using TestStack.Seleno.PageObjects;

namespace NGL.UiTests.Assessment
{
    public class AssessmentCreatePage : Page<CreateModel>
    {
        public AssessmentIndexPage CreateAssessment(CreateModel createAssessmentModel)
        {
            Input.ReplaceInputValueWith(m => m.Session, createAssessmentModel.Session);
            Input.ReplaceInputValueWith(m => m.SessionId, createAssessmentModel.SessionId);
            Input.ReplaceInputValueWith(m => m.Section, createAssessmentModel.Section);
            Input.ReplaceInputValueWith(m => m.SectionId, createAssessmentModel.SectionId);
            Input.ReplaceInputValueWith(m => m.AssessmentTitle, createAssessmentModel.AssessmentTitle);
            Input.ReplaceInputValueWith(m => m.AdministeredDate, createAssessmentModel.AdministeredDate);
            Input.SelectByOptionTextInDropDown(m => m.CommonCoreStandard, createAssessmentModel.CommonCoreStandard);
            Input.SelectByOptionTextInDropDown(m => m.QuestionType, createAssessmentModel.QuestionType.Humanize());
            Input.SelectByOptionTextInDropDown(m => m.GradeLevel, createAssessmentModel.GradeLevel.Humanize());
            Input.ReplaceInputValueWith(m => m.Mastery, createAssessmentModel.Mastery);
            Input.ReplaceInputValueWith(m => m.NearMastery, createAssessmentModel.NearMastery);

            return Navigate.To<AssessmentIndexPage>(By.ClassName("btn"));
        }
    }
}
