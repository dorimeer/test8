using OpenQA.Selenium;

namespace SeleniumCSharpNetCore.Pages
{
    public class ExternalPage
    {
        private readonly IWebDriver _driver;

        public ExternalPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement SearchPlaceholder => _driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[1]/div/div/div/div[2]/div/div/div/input"));

        public void Search(string someText) => SearchPlaceholder.SendKeys(someText);

        public bool IsSearchResultDisplayed() => _driver.FindElement(By.ClassName("ct-hero-title")).Displayed;
    }
}