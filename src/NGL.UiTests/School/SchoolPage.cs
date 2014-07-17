﻿using NGL.UiTests.Shared;
using NGL.Web.Models.School;
using OpenQA.Selenium;
using TestStack.Seleno.PageObjects;

namespace NGL.UiTests.School
{
    class SchoolPage : Page<SchoolModel>
    {
        public HomePage Save()
        {
            return Navigate.To<HomePage>(By.ClassName("btn"));
        }
    }
}