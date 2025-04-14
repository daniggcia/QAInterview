using QA.Interview.Drivers;
using TechTalk.SpecFlow;

namespace QA.Interview.Hooks
{
    [Binding]
    public class TestHooks
    {
        [AfterScenario]
        public void CleanUp()
        {
            WebDriverFactory.Quit();
        }
    }
}