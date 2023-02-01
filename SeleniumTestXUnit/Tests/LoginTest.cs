using OpenQA.Selenium;

namespace SeleniumTest.Tests;

[Collection("Selenium")]
public class LoginTest : IClassFixture<LoginPage>
{
    private readonly LoginPage _pageObjectModel;
    private readonly ITestOutputHelper _outputHelper;

    public LoginTest(LoginPage pageObjectModel, ITestOutputHelper output)
    {
        _outputHelper = output;
        _pageObjectModel = pageObjectModel;
    }

    [Fact]
    public void TestLoginUsingChromeWebDriver()
    {
        _pageObjectModel.LoginIntoApplication();

        string expectedDivElementId = "ctl00_MainContent_PanelAuth";
        var expectedDivElement = _pageObjectModel.WebDriver.Driver.FindElement(
            By.Id(expectedDivElementId)
        );

        Assert.True(expectedDivElement.Displayed, "The expected element wasn't displayed/found");
    }
}

/* Variables setup

        string emailCredentials = DotNetEnv.Env.GetString("TODO-LY-EMAIL");
        string passCredentials = DotNetEnv.Env.GetString("TODO-LY-PASSWORD");

        string loginButtonXPath =
            "//div[@id='ctl00_MainContent_PanelNotAuth']/div[contains(@class, 'HomePageTop2')]/div[contains(@class,'HPHeaderRight')]/div[contains(@class,'HPHeaderLogin')]/a";
        string emailInputXPath = "//input[@id='ctl00_MainContent_LoginControl1_TextBoxEmail']";
        string passInputXPath = "//input[@id='ctl00_MainContent_LoginControl1_TextBoxPassword']";
        string loginInputXPath = "//input[@id='ctl00_MainContent_LoginControl1_ButtonLogin']";

        /* Step execution

        ChromeFixture.ChromeDriver.Navigate().GoToUrl(_siteUrl);

        var loginButton = ChromeFixture.ChromeDriver.FindElement(By.XPath(loginButtonXPath));
        loginButton.Click();

        var emailInput = ChromeFixture.ChromeDriver.FindElement(By.XPath(emailInputXPath));
        emailInput.SendKeys(emailCredentials);

        var passInput = ChromeFixture.ChromeDriver.FindElement(By.XPath(passInputXPath));
        passInput.SendKeys(passCredentials);

        var loginInput = ChromeFixture.ChromeDriver.FindElement(By.XPath(loginInputXPath));
        loginInput.Click();

        /* Validation process

        string expectedDivElementXPath = "//div[@id='ctl00_MainContent_PanelAuth']";
        var expectedDivElement = ChromeFixture.ChromeDriver.FindElement(
            By.XPath(expectedDivElementXPath)
        );

        Assert.True(expectedDivElement.Displayed, "The expected element wasn't displayed/found");
        */
