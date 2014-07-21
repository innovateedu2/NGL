﻿using Humanizer;
using NGL.Web.Models.Enrollment;
using NGL.Web.Models.Student;
using TestStack.Seleno.PageObjects;

namespace NGL.UiTests.Student
{
    public class ProfilePage : Page<ProfileModel>
    {
        public bool AllFieldsExist(CreateStudentModel createStudentModel)
        {
            var studentFields =
                Browser.PageSource.Contains(createStudentModel.StudentUsi.ToString()) &&
                Browser.PageSource.Contains(createStudentModel.FirstName) &&
                Browser.PageSource.Contains(createStudentModel.LastName) &&
                Browser.PageSource.Contains(createStudentModel.Sex.Humanize()) &&
                Browser.PageSource.Contains(createStudentModel.BirthDate.GetValueOrDefault().ToString("MM-dd-yyyy")) &&
                Browser.PageSource.Contains(createStudentModel.HispanicLatinoEthnicity.ToString()) &&
                Browser.PageSource.Contains(createStudentModel.Race.Humanize()) &&
                Browser.PageSource.Contains(createStudentModel.HomeLanguage.GetValueOrDefault().ToString()) &&
                Browser.PageSource.Contains(createStudentModel.Address) &&
                Browser.PageSource.Contains(createStudentModel.Address2) &&
                Browser.PageSource.Contains(createStudentModel.City) &&
                Browser.PageSource.Contains(createStudentModel.State.Humanize()) &&
                Browser.PageSource.Contains(createStudentModel.PostalCode);


            var parentFields = 
                Browser.PageSource.Contains(createStudentModel.FirstParent.FirstName) &&
                Browser.PageSource.Contains(createStudentModel.FirstParent.LastName) &&
                Browser.PageSource.Contains(createStudentModel.FirstParent.Sex.Humanize()) &&
                Browser.PageSource.Contains(createStudentModel.FirstParent.RelationshipToStudent.Humanize()) &&
                Browser.PageSource.Contains(createStudentModel.FirstParent.TelephoneNumber) &&
                Browser.PageSource.Contains(createStudentModel.FirstParent.EmailAddress) &&
                Browser.PageSource.Contains(createStudentModel.FirstParent.SameAddressAsStudent.ToString());

            return studentFields && parentFields;
        }

    }
}
