using System;
using OpenQA.Selenium;
using SeleniumTest.Core;
using SeleniumTest.Core.Drivers;

public class LoginPage : IDisposable
{
    public ChromeWebDriver WebDriver;

    public LoginPage()
    {
        WebDriver = new ChromeWebDriver();
    }

    public readonly string HostUrl = "https://todo.ly";
    public readonly string EmailCredentials = ConfigBuilder.Instance.GetString("TODO-LY-EMAIL");
    public readonly string PassCredentials = ConfigBuilder.Instance.GetString("TODO-LY-PASSWORD");

    public readonly string LoginButtonClass = "HPHeaderLogin";
    public readonly string EmailInputId = "ctl00_MainContent_LoginControl1_TextBoxEmail";
    public readonly string PassInputId = "ctl00_MainContent_LoginControl1_TextBoxPassword";
    public readonly string LoginInputId = "ctl00_MainContent_LoginControl1_ButtonLogin";

    public void LoginIntoApplication()
    {
        WebDriver.Driver.Navigate().GoToUrl(HostUrl);

        var loginButton = WebDriver.Driver.FindElement(By.ClassName(LoginButtonClass));
        loginButton.Click();

        var emailInput = WebDriver.Driver.FindElement(By.Id(EmailInputId));
        emailInput.SendKeys(EmailCredentials);

        var passInput = WebDriver.Driver.FindElement(By.Id(PassInputId));
        passInput.SendKeys(PassCredentials);

        var loginInput = WebDriver.Driver.FindElement(By.Id(LoginInputId));
        loginInput.Click();
    }

    public void Dispose()
    {
        WebDriver.Driver.Dispose();
    }
}
