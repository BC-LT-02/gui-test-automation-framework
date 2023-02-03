using System;
using System.Linq;
using SeleniumTest.Core.Drivers;
using SeleniumTest.Core.Interfaces;
using TechTalk.SpecFlow;

namespace SeleniumTest.Tests.Steps.Item;

[Binding]
[Scope(Feature = "Set Date for an Item")]
public class SetDateStepDefinitions : IClassFixture<ChromeWebDriver>
{
    private readonly ScenarioContext _scenarioContext;
    private readonly IGenericWebDriver _driver;

    public SetDateStepDefinitions(ScenarioContext scenarioContext, ChromeWebDriver driver)
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

    [Given(@"the user selected an item")]
    public void Giventheuserselectedanitem()
    {
        _scenarioContext.Pending();
    }

    [When(@"the user clicks on the Set Due Date")]
    public void WhentheuserclicksontheSetDueDate()
    {
        _scenarioContext.Pending();
    }

    [Then(@"enters a date and time and saves")]
    public void Thenentersadateandtimeandsaves()
    {
        _scenarioContext.Pending();
    }

    [Then(@"the item should be displayed in the list with the specified date")]
    public void Thentheitemshouldbedisplayedintheprojectlistwiththespecifieddate()
    {
        _scenarioContext.Pending();
    }

    [Then(@"the user sets an invalid date or time for the item")]
    public void Thentheusersetsaninvaliddateortimefortheitem()
    {
        _scenarioContext.Pending();
    }

    [Then(@"an error message should be displayed indicating that the date is invalid should be displayed")]
    public void Thenanerrormessageshouldbedisplayedindicatingthatthedateisinvalidshouldbedisplayed()
    {
        _scenarioContext.Pending();
    }
}
