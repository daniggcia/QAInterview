using FluentAssertions;
using OpenQA.Selenium;
using QA.Interview.Pages;
using QA.Interview.Drivers;
using TechTalk.SpecFlow;

namespace QA.Interview.StepDefinitions
{
    [Binding]
    public class RentalsSteps
    {
        private readonly MainPage _mainPage;
        private readonly RentalsPage _rentalsPage;

        public RentalsSteps()
        {
            _mainPage = new MainPage(WebDriverFactory.Driver);
            _rentalsPage = new RentalsPage(WebDriverFactory.Driver);
        }
       
       [Then("the titles of the tools should be displayed correctly")]
        public void ThenTheTitlesOfTheToolsShouldBeDisplayedCorrectly()
        {
            var titles = _rentalsPage.GetAllTitles();
            titles.Should().OnlyContain(title => !string.IsNullOrWhiteSpace(title));
        }
    }
}