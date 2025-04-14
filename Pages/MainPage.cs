using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace QA.Interview.Pages
{
    public class MainPage
    {
        private readonly IWebDriver _driver;

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToCategory(string subcategory, string category)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            // Si hay menú responsive, lo abrimos
            try
            {
                var toggleButton = _driver.FindElement(By.CssSelector("button.navbar-toggler"));
                if (toggleButton.Displayed)
                {
                    toggleButton.Click();
                }
            }
            catch (NoSuchElementException)
            {
            }
        }
    }
}