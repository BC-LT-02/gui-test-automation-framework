using System;
using System.Linq;
using SeleniumTest.Core.Drivers;
using SeleniumTest.Core.Interfaces;
using TechTalk.SpecFlow;

namespace SeleniumTest.Tests.Steps.Item;

[Binding]
[Scope(Feature = "Create an Item above")]
public class CreateAboveStepDefinitions : IClassFixture<ChromeWebDriver>
{
    private readonly ScenarioContext _scenarioContext;
    private readonly IGenericWebDriver _driver;

    public CreateAboveStepDefinitions(ScenarioContext scenarioContext, ChromeWebDriver driver)
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

    [Given(@"the user clicks on an item")]
    public void Giventheuserclicksonanitem()
    {
        _scenarioContext.Pending();
    }

    [When(@"the user clicks on the Add item above")]
    public void WhentheuserclicksontheAdditemabove()
    {
        _scenarioContext.Pending();
    }

    [Then(@"the user enters an item name")]
    public void Thentheuserentersanitemname()
    {
        _scenarioContext.Pending();
    }

    [Then(@"the item should be displayed above the selected item in the project list")]
    public void Thentheitemshouldbedisplayedabovetheselecteditemintheprojectlist()
    {
        _scenarioContext.Pending();
    }
}
