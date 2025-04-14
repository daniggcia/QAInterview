using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace QA.Interview.Pages;

public class PowerToolsPage
{
    private readonly IWebDriver _driver;

    public PowerToolsPage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void SelectFirstProduct()
    {
        var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        var firstProduct = wait.Until(driver =>
            driver.FindElement(By.CssSelector("a[data-test^='product-']")));
        firstProduct.Click();
    }

    public void AddToCart()
    {
        var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        var addToCartButton = wait.Until(driver =>
            driver.FindElement(By.CssSelector("button[data-test='add-to-cart']")));
    
        addToCartButton.Click();
    }
}