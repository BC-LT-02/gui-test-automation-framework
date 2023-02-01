using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest.Core.Drivers;

public class ChromeWebDriver
{
    public IWebDriver Driver { get; }
    private readonly ConfigBuilder _config = ConfigBuilder.Instance;

    public ChromeWebDriver()
    {
        Driver = new ChromeDriver();
        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(
            _config.GetInt("DriverImplicitTimeout")
        );
        Driver.Manage().Window.Maximize();
    }
}

/*
public class ChromeWebDriver
{
    public IWebDriver Driver { get; }
    private readonly ConfigBuilder _config = ConfigBuilder.Instance;

    private static readonly ChromeWebDriver _instance = new ChromeWebDriver();

    private ChromeWebDriver()
    {
        Driver = new ChromeDriver();
        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(
            _config.GetInt("DriverImplicitTimeout")
        );
        Driver.Manage().Window.Maximize();
    }

    public void Dispose()
    {
        Driver.Dispose();
    }

    public static ChromeWebDriver Instance => _instance;
}
*/
