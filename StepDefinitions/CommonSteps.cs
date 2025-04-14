using TechTalk.SpecFlow;
using QA.Interview.Drivers;
using QA.Interview.Pages;

[Binding]
public class CommonSteps
{
    [Given("I am on the homepage")]
    public void GivenIAmOnTheHomepage()
    {
        WebDriverFactory.Driver.Navigate().GoToUrl("https://practicesoftwaretesting.com");
    }

    [When(@"I navigate to the ""(.*)"" section from the ""(.*)"" menu")]
    public void WhenINavigateToSection(string section, string menu)
    {
        if (section == "Rentals")
        {
            WebDriverFactory.Driver.Navigate().GoToUrl("https://practicesoftwaretesting.com/rentals");
        }
        else if (section == "Hand Tools")
        {
            WebDriverFactory.Driver.Navigate().GoToUrl("https://practicesoftwaretesting.com/category/hand-tools");
        }
    }
}