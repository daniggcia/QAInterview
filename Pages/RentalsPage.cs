using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace QA.Interview.Pages
{
    public class RentalsPage
    {
        private readonly IWebDriver _driver;

        public RentalsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public List<string> GetAllTitles()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            wait.Until(driver =>
            {
                var elements = driver.FindElements(By.CssSelector("h5.card-title"));
                return elements.Any(e => e.Displayed);
            });

            var titleElements = _driver.FindElements(By.CssSelector("h5.card-title"));

            Console.WriteLine($"🔍 Encontrados {titleElements.Count} títulos de herramientas en Rentals:");

            foreach (var el in titleElements)
            {
                Console.WriteLine($"- Texto crudo: '{el.Text}' | Visible: {el.Displayed}");
            }

            return titleElements
                .Where(e => e.Displayed)
                .Select(e => e.Text.Trim())
                .Where(text => !string.IsNullOrWhiteSpace(text))
                .ToList();
        }
    }
}