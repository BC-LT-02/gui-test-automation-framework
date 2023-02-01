using OpenQA.Selenium;

namespace SeleniumTest.Tests;

[Collection("Selenium")]
public class LoginTest2 : IClassFixture<LoginPage>
{
    private readonly LoginPage _pageObjectModel;
    private readonly ITestOutputHelper _outputHelper;

    public LoginTest2(LoginPage pageObjectModel, ITestOutputHelper output)
    {
        _outputHelper = output;
        _pageObjectModel = pageObjectModel;
    }

    [Fact]
    public void TestLoginUsingChromeWebDriver2()
    {
        _pageObjectModel.LoginIntoApplication();

        string expectedDivElementId = "ctl00_MainContent_PanelAuth";
        var expectedDivElement = _pageObjectModel.WebDriver.Driver.FindElement(
            By.Id(expectedDivElementId)
        );

        Assert.True(expectedDivElement.Displayed, "The expected element wasn't displayed/found");
    }
}
