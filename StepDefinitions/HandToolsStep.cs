using FluentAssertions;
using OpenQA.Selenium;
using QA.Interview.Pages;
using QA.Interview.Drivers;
using TechTalk.SpecFlow;

namespace QA.Interview.StepDefinitions
{
    [Binding]
    public class HandToolsSteps
    {
        private readonly MainPage _mainPage;
        private readonly HandToolsPage _handToolsPage;

        public HandToolsSteps()
        {
            _mainPage = new MainPage(WebDriverFactory.Driver);
            _handToolsPage = new HandToolsPage(WebDriverFactory.Driver);
        }

        
        [When(@"I filter by category ""(.*)""")]
        public void WhenIFilterByCategory(string category)
        {
            _handToolsPage.FilterByCategory(category);
        }

        [When(@"I filter by brand ""(.*)""")]
        public void WhenIFilterByBrand(string brand)
        {
            _handToolsPage.FilterByBrand(brand);
        }

        [Then("all tool prices should be greater than zero")]
        public void ThenAllPricesShouldBeGreaterThanZero()
        {
            var prices = _handToolsPage.GetAllPrices();
            prices.Should().OnlyContain(p => p > 0);
        }
    }
}