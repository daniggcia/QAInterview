using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace QA.Interview.Pages
{
    public class HandToolsPage
    {
        private readonly IWebDriver _driver;

        public HandToolsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void FilterByCategory(string category)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var checkbox = wait.Until(ExpectedConditions.ElementToBeClickable(
                By.XPath($"//label[contains(.,'{category}')]")));
            checkbox.Click();
        }

        
        public void FilterByBrand(string brand)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var checkbox = wait.Until(ExpectedConditions.ElementToBeClickable(
                By.XPath($"//label[contains(.,'{brand}')]")));
            checkbox.Click();
        }

        public List<decimal> GetAllPrices()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElements(By.CssSelector("[data-test='product-price']")).Count > 0);

            var priceElements = _driver.FindElements(By.CssSelector("[data-test='product-price']"));

            return priceElements
                .Select(e =>
                {
                    var raw = e.Text.Replace("$", "").Trim();
                    return decimal.Parse(raw, CultureInfo.InvariantCulture);
                })
                .ToList();
        }
    }
}