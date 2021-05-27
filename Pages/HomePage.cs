using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    internal class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement LnkLogin => _driver.FindElement(By.LinkText("Login"));

        private IWebElement LnkLogOff => _driver.FindElement(By.LinkText("Log off"));
        
        private IWebElement LnkVisitNow => _driver.FindElement(By.LinkText("Visit now »"));

        public void ClickLogin() => LnkLogin.Click();

        public bool IsLogOffExist() => LnkLogOff.Displayed;

        public void ClickVisitNow() => LnkVisitNow.Click();
    }
}
