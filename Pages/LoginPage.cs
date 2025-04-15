using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace QA.Interview.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void FillCredentials(string email, string password)
        {
            if (!_driver.Url.Contains("/auth/login") && !_driver.Url.Contains("/checkout"))
            {
                Console.WriteLine("🔁 Navegando manualmente al checkout...");
                _driver.Navigate().GoToUrl("https://practicesoftwaretesting.com/checkout");
            }

            Console.WriteLine($"🌐 URL actual: {_driver.Url}");

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var emailInput = wait.Until(driver => driver.FindElement(By.CssSelector("input[data-test='email']")));
            var passwordInput = wait.Until(driver => driver.FindElement(By.CssSelector("input[data-test='password']")));

            // Ejecutamos JS directamente para evitar problemas de interacción
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("arguments[0].value = arguments[1];", emailInput, email);
            js.ExecuteScript("arguments[0].value = arguments[1];", passwordInput, password);
        }
        public void ClickLogin()
        {
            Console.WriteLine("Haciendo clic en el botón de login...");

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var loginButton = wait.Until(driver => driver.FindElement(By.CssSelector("input[data-test='login-submit']")));

            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("arguments[0].click();", loginButton);
        }

        public bool CheckInvalidLoginError()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            try
            {
                var error = wait.Until(driver =>
                {
                    var el = driver.FindElement(By.CssSelector(".alert.alert-danger"));
                    return el.Displayed ? el : null;
                });

                return error.Text.Contains("Invalid email or password");
            }
            catch
            {
                return false;
            }
        }
    }
}