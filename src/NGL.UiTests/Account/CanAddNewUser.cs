﻿using NGL.Tests.Builders;
using NGL.UiTests.Shared;
using NGL.Web.Models.Account;
using Shouldly;
using TestStack.BDDfy;
using Xunit;

namespace NGL.UiTests.Account
{
    [Story(
        AsA = "Master Admin",
        IWant = "to add new user",
        SoThat = "school staff can login to the website")]
    public class CanAddNewUser
    {
        private HomePage _homePage;
        private UsersPage _usersPage;
        private readonly AddUserModel _newUser = new AddUserModelBuilder().WithStaffUsi(1234).Build();

        void GivenIHaveLoggedInAsAMasterAdmin()
        {
            _homePage = Host
                .Instance
                .NavigateToInitialPage<HomePage>()
                .Login(ObjectMother.UserJohnSmith.ViewModel);
        }

        void WhenINavigateToUsersManagerPage()
        {
            _usersPage = _homePage.TopMenu.GoToUsersPage();
        }

        void AndWhenICreateANewUserAsAdmin()
        {
            _usersPage.GoToAddUserPage().Register(_newUser);
        }

        void ThenTheUserAppearsOnTheUserLists()
        {
            _usersPage.UserExists(_newUser).ShouldBe(true);
        }

        void AndTheUserCanLogin()
        {
            _homePage.TopMenu.LogOff().Login(new LoginModel {Username = _newUser.Username, Password = _newUser.Password});
            _homePage.TopMenu.IsLoggedOn.ShouldBe(true);
        }

        [Fact]
        public void Verify()
        {
            this.BDDfy();
        }
    }
}
