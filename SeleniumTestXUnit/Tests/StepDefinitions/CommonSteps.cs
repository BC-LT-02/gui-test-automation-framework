using System.Linq;
using SeleniumTest.Core.Drivers;
using SeleniumTest.Core.Interfaces;
using TechTalk.SpecFlow;

namespace SeleniumTest.Tests.Steps.Commons;

public class CommonSteps : IClassFixture<ChromeWebDriver>
{
    private readonly IGenericWebDriver _driver;
    private readonly ScenarioContext _scenarioContext;

    public CommonSteps(ScenarioContext scenarioContext, ChromeWebDriver driver)
    {
        _scenarioContext = scenarioContext;
        _driver = driver;
    }

    [Given(@"the user is logged in")]
    public void Giventheuserisloggedin()
    {
        _scenarioContext.Pending();
    }

    [Given(@"the user has an existing project")]
    public void Giventheuserhasanexistingproject()
    {
        _scenarioContext.Pending();
    }

    [Given(@"the user has an existing item")]
    public void Giventheuserhasanexistingitem()
    {
        _scenarioContext.Pending();
    }
}
