using System;
using System.Linq;
using SeleniumTest.Core.Drivers;
using SeleniumTest.Core.Interfaces;
using SeleniumTest.Tests.Steps.Commons;
using TechTalk.SpecFlow;

namespace SeleniumTest.Tests.Steps.Item;

[Binding]
[Scope(Feature = "Update Item")]
[Collection("Selenium")]
public class UpdateStepDefinitions : CommonSteps
{
    private readonly IGenericWebDriver _driver;
    private readonly ScenarioContext _scenarioContext;

    public UpdateStepDefinitions(ScenarioContext scenarioContext, ChromeWebDriver driver)
        : base(scenarioContext, driver)
    {
        _scenarioContext = scenarioContext;
        _driver = driver;
        Skip.If(_scenarioContext.ScenarioInfo.Tags.Contains("Draft"));
    }

    [When(@"the user clicks the item name box")]
    public void Whentheuserclickstheitemnamebox()
    {
        _scenarioContext.Pending();
    }

    [Given(@"the user inputs a new item name")]
    public void Giventheuserinputsanewitemname()
    {
        _scenarioContext.Pending();
    }

    [Then(@"the site updates the item nameS")]
    public void ThenthesiteupdatestheitemnameS()
    {
        _scenarioContext.Pending();
    }
}
