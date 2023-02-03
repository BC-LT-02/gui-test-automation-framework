using System;
using System.Linq;
using SeleniumTest.Core.Drivers;
using SeleniumTest.Core.Interfaces;
using TechTalk.SpecFlow;

namespace SeleniumTest.Tests.Steps.Item;

[Binding]
[Scope(Feature = "Uncheck an Item")]
public class UncheckItemStepDefinitions : IClassFixture<ChromeWebDriver>
{
    private readonly ScenarioContext _scenarioContext;
    private readonly IGenericWebDriver _driver;

    public UncheckItemStepDefinitions(ScenarioContext scenarioContext, ChromeWebDriver driver)
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

    [When(@"the user unchecks the item")]
    public void Whentheuseruncheckstheitem()
    {
        _scenarioContext.Pending();
    }

    [Then(@"the item should not be displayed in the Done Items list")]
    public void ThentheitemshouldnotbedisplayedintheDoneItemslist()
    {
        _scenarioContext.Pending();
    }
}
