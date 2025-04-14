using OpenQA.Selenium;
using QA.Interview.Pages;
using TechTalk.SpecFlow;

namespace QA.Interview.StepDefinitions;

[Binding]
public class CheckoutSteps
{
    private readonly IWebDriver _driver;
    private readonly PowerToolsPage _powerToolsPage;
    private readonly CartPage _cartPage;
    private readonly LoginPage _loginPage;

    public CheckoutSteps()
    {
        _driver = Drivers.WebDriverFactory.Driver;
        _powerToolsPage = new PowerToolsPage(_driver);
        _cartPage = new CartPage(_driver);
        _loginPage = new LoginPage(_driver);
        
    }

    [When(@"I select the first product")]
    public void WhenISelectTheFirstProduct()
    {
        _powerToolsPage.SelectFirstProduct();
    }

    [When(@"I add the product to the cart")]
    public void WhenIAddTheProductToTheCart()
    {
        _powerToolsPage.AddToCart();
    }

    [When(@"I go to the cart and proceed to checkout")]
    public void WhenIGoToTheCartAndProceedToCheckout()
    {
        _cartPage.OpenCartAndProceedToCheckout();
    }

    [When(@"I enter an invalid email and any password")]
    public void WhenIEnterAnInvalidEmailAndAnyPassword()
    {
        _loginPage.FillCredentials("correo-invalido", "1234");
    }

    [When(@"I click the login button")]
    public void WhenIClickTheLoginButton()
    {
        _loginPage.ClickLogin();
    }

    [Then(@"I should see an error message for invalid credentials")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        _loginPage.CheckInvalidLoginError();
    }
    
    [When(@"I proceed to checkout")]
    public void WhenIProceedToCheckout()
    {
        _cartPage.OpenCartAndProceedToCheckout();
    }

    [When(@"I enter invalid email ""(.*)"" and password ""(.*)""")]
    public void WhenIEnterInvalidEmailAndPassword(string email, string password)
    {
       _cartPage.ClickProceedToCheckout();
        _loginPage.FillCredentials(email, password);
    }

    [When(@"I attempt to login")]
    public void WhenIAttemptToLogin()
    {
        _loginPage.ClickLogin();
    }
    
}