using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement TxtUserName => _driver.FindElement(By.Name("UserName"));
        private IWebElement TxtPassword => _driver.FindElement(By.Name("Password"));
        private IWebElement BtnLogin => _driver.FindElement(By.CssSelector(".btn-default"));


        public void EnterUserNameAndPassword(string userName, string password)
        {
            TxtUserName.SendKeys(userName);
            TxtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            BtnLogin.Click();
        }
    }
}
