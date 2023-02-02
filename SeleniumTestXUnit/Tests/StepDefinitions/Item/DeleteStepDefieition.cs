using System;
using System.Linq;
using SeleniumTest.Core.Drivers;
using SeleniumTest.Core.Interfaces;
using SeleniumTest.Tests.Steps.Commons;
using TechTalk.SpecFlow;

namespace SeleniumTest.Tests.Steps.Item;

[Binding]
[Scope(Feature = "Item Deletion")]
[Collection("Selenium")]
public class DeleteStepDefinitions : CommonSteps
{
    private readonly IGenericWebDriver _driver;
    private readonly ScenarioContext _scenarioContext;

    public DeleteStepDefinitions(ScenarioContext scenarioContext, ChromeWebDriver driver)
        : base(scenarioContext, driver)
    {
        _scenarioContext = scenarioContext;
        _driver = driver;
        Skip.If(_scenarioContext.ScenarioInfo.Tags.Contains("Draft"));
    }

    [Given(@"the user has a pending item in the main items section")]
    public void Giventheuserhasapendingiteminthemainitemssection()
    {
        _scenarioContext.Pending();
    }

    [When(@"the user hovers over the item")]
    public void Whentheuserhoversovertheitem()
    {
        _scenarioContext.Pending();
    }

    [Given(@"clicks on the menu list")]
    public void Givenclicksonthemenulist()
    {
        _scenarioContext.Pending();
    }

    [Given(@"clicks on the delete option")]
    public void Givenclicksonthedeleteoption()
    {
        _scenarioContext.Pending();
    }

    [Then(@"the item should be removed from the section")]
    public void Thentheitemshouldberemovedfromthesection()
    {
        _scenarioContext.Pending();
    }

    [Given(@"it should be added to the Recycle Bin section")]
    public void GivenitshouldbeaddedtotheRecycleBinsection()
    {
        _scenarioContext.Pending();
    }

    [Given(@"I have at least two done items located in the done items section")]
    public void GivenIhaveatleasttwodoneitemslocatedinthedoneitemssection()
    {
        _scenarioContext.Pending();
    }

    [When(@"the user clicks on the delete all option")]
    public void Whentheuserclicksonthedeletealloption()
    {
        _scenarioContext.Pending();
    }

    [Then(@"the items should be removed from the section")]
    public void Thentheitemsshouldberemovedfromthesection()
    {
        _scenarioContext.Pending();
    }

    [Given(@"they should be added to the Recycle bin section")]
    public void GiventheyshouldbeaddedtotheRecyclebinsection()
    {
        _scenarioContext.Pending();
    }
}
