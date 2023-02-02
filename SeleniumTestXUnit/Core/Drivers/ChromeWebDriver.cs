using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Core.Interfaces;

namespace SeleniumTest.Core.Drivers;

public class ChromeWebDriver : IGenericWebDriver
{
    private readonly IWebDriver _driver;

    public ChromeWebDriver()
    {
        _driver = new ChromeDriver();
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(
            ConfigModel.DriverExplicitTimeout
        );
        _driver.Manage().Window.Maximize();
    }

    public IWebDriver Instance()
    {
        return _driver;
    }

    public void Dispose()
    {
        _driver.Dispose();
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

    public static ChromeWebDriver Instance => _instance; //New changes
}
*/
