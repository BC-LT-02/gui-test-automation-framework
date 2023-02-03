using System;
using System.Linq;
using SeleniumTest.Core.Drivers;
using SeleniumTest.Core.Interfaces;
using TechTalk.SpecFlow;

namespace SeleniumTest.Tests.Steps.Item;

[Binding]
[Scope(Feature = "Create an Item in a Project")]
public class CreateStepDefinitions : IClassFixture<ChromeWebDriver>
{
    private readonly ScenarioContext _scenarioContext;
    private readonly IGenericWebDriver _driver;

    public CreateStepDefinitions(ScenarioContext scenarioContext, ChromeWebDriver driver)
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

    [Given(@"the user has selected a project")]
    public void Giventheuserhasselectedaproject()
    {
        _scenarioContext.Pending();
    }

    [When(@"the user clicks on the Add New Todo")]
    public void Whentheuserclicksonthe()
    {
        _scenarioContext.Pending();
    }

    [Then(@"the user enters an item name")]
    public void Thentheuserentersanitemname()
    {
        _scenarioContext.Pending();
    }

    [Then(@"the item should be displayed in the project list")]
    public void Thentheitemshouldbedisplayedintheprojectlist()
    {
        _scenarioContext.Pending();
    }

    [When(@"the user tries to create an item with an empty")]
    public void Whentheusertriestocreateanitemwithanempty()
    {
        _scenarioContext.Pending();
    }

    [Then(@"an error message indicating that the item name is required should be displayed")]
    public void Thenanerrormessageindicatingthattheitemnameisrequiredshouldbedisplayed()
    {
        _scenarioContext.Pending();
    }
}
