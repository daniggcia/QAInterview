using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QA.Interview.Drivers;

public static class WebDriverFactory
{
    private static IWebDriver? _driver;

    public static IWebDriver Driver
    {
        get
        {
            if (_driver == null)
            {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");

                // Ruta al chromedriver que ya tienes descargado
                var chromeDriverPath = @"D:\projectsRider\QA.Interview\Drivers";

                _driver = new ChromeDriver(chromeDriverPath, options);
            }

            return _driver;
        }
    }

    public static void Quit()
    {
        _driver?.Quit();
        _driver = null;
    }
}