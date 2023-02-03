using System;
using System.Linq;
using SeleniumTest.Core.Drivers;
using SeleniumTest.Core.Interfaces;
using TechTalk.SpecFlow;

namespace SeleniumTest.Tests.Steps.Item;

[Binding]
[Scope(Feature = "Check an Item")]
public class CheckItemStepDefinitions : IClassFixture<ChromeWebDriver>
{
    private readonly ScenarioContext _scenarioContext;
    private readonly IGenericWebDriver _driver;

    public CheckItemStepDefinitions(ScenarioContext scenarioContext, ChromeWebDriver driver)
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

    [Given(@"the user has selected an item")]
    public void Giventheuserhasselectedanitem()
    {
        _scenarioContext.Pending();
    }

    [When(@"the user checks the item")]
    public void Whentheusercheckstheitem()
    {
        _scenarioContext.Pending();
    }

    [Then(@"the item should be displayed in the Done Items list")]
    public void ThentheitemshouldbedisplayedintheDoneItemslist()
    {
        _scenarioContext.Pending();
    }
}
