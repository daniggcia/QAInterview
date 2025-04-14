using OpenQA.Selenium;
using FluentAssertions;
using OpenQA.Selenium.Support.UI;

namespace QA.Interview.Pages;

public class LoginPage
{
    private readonly IWebDriver _driver;

    public LoginPage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void FillCredentials(string email, string password)
    {
        var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

        var emailField = wait.Until(driver =>
        {
            var element = driver.FindElement(By.CssSelector("#email"));
            return element.Displayed && element.Enabled ? element : null;
        });

        emailField.Clear();
        emailField.SendKeys(email);

        var passwordField = wait.Until(driver =>
        {
            var element = driver.FindElement(By.CssSelector("#password"));
            return element.Displayed && element.Enabled ? element : null;
        });

        passwordField.Clear();
        passwordField.SendKeys(password);
    }

    public void ClickLogin()
    {
        var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        var loginButton = wait.Until(driver =>
            driver.FindElement(By.CssSelector("button[data-test='login']")));

        loginButton.Click();
    }

    public void CheckInvalidLoginError()
    {
        var errorMessage = _driver.FindElement(By.CssSelector(".alert-danger")).Text;
        errorMessage.Should().Contain("Invalid credentials");
    }
}