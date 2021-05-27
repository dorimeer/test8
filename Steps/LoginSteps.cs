using NUnit.Framework;
using SeleniumCSharpNetCore.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumCSharpNetCore.Steps
{

    [Binding]
    public class LoginSteps
    {

        private readonly DriverHelper _driverHelper;
        private readonly HomePage _homePage;
        private readonly LoginPage _loginPage;

        public LoginSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            _homePage = new HomePage(_driverHelper.Driver);
            _loginPage = new LoginPage(_driverHelper.Driver);
        }

       


        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _driverHelper.Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Given(@"I click the Login link")]
        public void GivenIClickTheLoginLink()
        {
            _homePage.ClickLogin();
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _loginPage.EnterUserNameAndPassword(data.UserName, data.Password);
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            _loginPage.ClickLogin();
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            Assert.That(_homePage.IsLogOffExist(), Is.True, "Log off button did not displayed");
        }



    }
}
