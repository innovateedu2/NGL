﻿using OpenQA.Selenium;
using TestStack.Seleno.PageObjects;

namespace NGL.UiTests.Pages
{
    class TopMenu : UiComponent
    {
        public SchoolPage GoToSchoolPage()
        {
            return Navigate.To<SchoolPage>(By.LinkText("School Info"));
        }

        public LoginPage GoToLoginPage()
        {
            return Navigate.To<LoginPage>(By.LinkText("Log in"));
        }

        public StudentPage GoToStudentPage()
        {
            return Navigate.To<StudentPage>(By.LinkText("Students"));
        }
    }
}