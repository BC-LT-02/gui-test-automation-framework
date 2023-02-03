using System;
using System.Linq;
using SeleniumTest.Core.Drivers;
using SeleniumTest.Core.Interfaces;
using TechTalk.SpecFlow;

namespace SeleniumTest.Tests.Steps.Item;

[Binding]
[Scope(Feature = "Postpone Date for an Item")]
public class PostponeStepDefinitions : IClassFixture<ChromeWebDriver>
{
    private readonly ScenarioContext _scenarioContext;
    private readonly IGenericWebDriver _driver;

    public PostponeStepDefinitions(ScenarioContext scenarioContext, ChromeWebDriver driver)
    {
        _scenarioContext = scenarioContext;
        _driver = driver;
        Skip.If(_scenarioContext.ScenarioInfo.Tags.Contains("Draft"));
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

    [Given(@"the project has one or more existing items")]
    public void Giventheprojecthasoneormoreexistingitems()
    {
        _scenarioContext.Pending();
    }

    [Given(@"the item selected has a date")]
    public void Giventheitemselectedhasadate()
    {
        _scenarioContext.Pending();
    }

    [Given(@"the user clicks on the date of the item")]
    public void Giventheuserclicksonthedateoftheitem()
    {
        _scenarioContext.Pending();
    }

    [When(@"the user selects one of the options to postpone the date")]
    public void Whentheuserselectsoneoftheoptionstopostponethedate()
    {
        _scenarioContext.Pending();
    }

    [Then(@"clicks on Postpone button")]
    public void ThenclicksonPostponebutton()
    {
        _scenarioContext.Pending();
    }

    [Then(@"the item should be displayed in the list with the postponed date")]
    public void Thentheitemshouldbedisplayedinthelistwiththepostponeddate()
    {
        _scenarioContext.Pending();
    }
}
