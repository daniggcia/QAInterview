using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace QA.Interview.Pages;

public class CartPage
{
    private readonly IWebDriver _driver;

    public CartPage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void OpenCartAndProceedToCheckout()
    {
        var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        var cartButton = wait.Until(driver =>
            driver.FindElement(By.CssSelector("a[data-test='nav-cart']")));
        cartButton.Click();
    }
    public void ClickProceedToCheckout()
    {
        var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

        var proceedButton = wait.Until(driver =>
            driver.FindElement(By.CssSelector("button[data-test='proceed-1']")));

        proceedButton.Click();
    }
}