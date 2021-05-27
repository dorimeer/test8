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
    public class SecondFeatureSteps
    {
        private readonly DriverHelper _driverHelper;
        private readonly HomePage _homePage;
        private readonly ExternalPage _externalPage;
        
        public SecondFeatureSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            _homePage = new HomePage(_driverHelper.Driver);
            _externalPage = new ExternalPage(_driverHelper.Driver);
        }

        [Given(@"I click the VisitNow link")]
        public void GivenIClickTheVisitNowLink()
        {
            _homePage.ClickVisitNow();
        }
        
        [Given(@"I enter SomeText to search")]
        public void GivenIEnterSomeTextToSearch(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _externalPage.Search(data.SomeText);
        }
        [Then(@"I should see result of search")]
        public void ThenIShouldSeeResultOfSearch()
        {
            Assert.That(_externalPage.IsSearchResultDisplayed);
        }
    }
}