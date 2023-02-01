/*
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumTest.Core.Drivers;
using SeleniumTest.Helpers;

namespace SeleniumTest.Tests;

[Collection("Selenium")]
public class FullScenarioTest : IClassFixture<ChromeWebDriverFixture>
{
    private readonly ChromeWebDriverFixture ChromeFixture;
    private readonly ITestOutputHelper _outputHelper;
    private readonly string _siteUrl;

    public FullScenarioTest(ChromeWebDriverFixture fixture, ITestOutputHelper output)
    {
        ChromeFixture = fixture;
        _outputHelper = output;

        _siteUrl = "https://todo.ly/";

        DotNetEnv.Env.TraversePath().Load();
    }

    [Fact]
    public void TestFullScenario()
    {
        /* Step execution

        ChromeFixture.ChromeDriver.Navigate().GoToUrl(_siteUrl);

        /* Login Process
        string emailCredentials = DotNetEnv.Env.GetString("TODO-LY-EMAIL");
        string passCredentials = DotNetEnv.Env.GetString("TODO-LY-PASSWORD");

        string loginButtonXPath =
            "//div[@id='ctl00_MainContent_PanelNotAuth']/div[contains(@class, 'HomePageTop2')]/div[contains(@class,'HPHeaderRight')]/div[contains(@class,'HPHeaderLogin')]/a";
        string emailInputXPath = "//input[@id='ctl00_MainContent_LoginControl1_TextBoxEmail']";
        string passInputXPath = "//input[@id='ctl00_MainContent_LoginControl1_TextBoxPassword']";
        string loginInputXPath = "//input[@id='ctl00_MainContent_LoginControl1_ButtonLogin']";

        var loginButton = ChromeFixture.ChromeDriver.FindElement(By.XPath(loginButtonXPath));
        loginButton.Click();

        var emailInput = ChromeFixture.ChromeDriver.FindElement(By.XPath(emailInputXPath));
        emailInput.SendKeys(emailCredentials);

        var passInput = ChromeFixture.ChromeDriver.FindElement(By.XPath(passInputXPath));
        passInput.SendKeys(passCredentials);

        var loginInput = ChromeFixture.ChromeDriver.FindElement(By.XPath(loginInputXPath));
        loginInput.Click();

        /* Create a project process
        string tempProjectName = IdHelper.GetNewId();
        string addNewProjectXPath =
            "//div[contains(@class,'AddProjectLiDiv') and contains(@onclick,'ShowAddNewProject')]";
        string newProjectInputXPath = "//input[@id='NewProjNameInput']";

        var addNewProjectButton = ChromeFixture.ChromeDriver.FindElement(
            By.XPath(addNewProjectXPath)
        );
        addNewProjectButton.Click();

        var newProjectInput = ChromeFixture.ChromeDriver.FindElement(
            By.XPath(newProjectInputXPath)
        );
        newProjectInput.SendKeys(tempProjectName);
        newProjectInput.SendKeys(Keys.Return);

        /* Create an item process

        string tempItemName = IdHelper.GetNewId();
        string addNewItemTextAreaXPath = "//textarea[@id='NewItemContentInput']";

        var addNewItemTextArea = ChromeFixture.ChromeDriver.FindElement(
            By.XPath(addNewItemTextAreaXPath)
        );
        addNewItemTextArea.SendKeys(tempItemName);
        addNewItemTextArea.SendKeys(Keys.Return);

        /* Check item process

        string itemCheckboxXPath = "//input[@id='ItemCheckBox' and @itemid]";

        var itemCheckbox = ChromeFixture.ChromeDriver.FindElement(By.XPath(itemCheckboxXPath));
        itemCheckbox.Click();

        /* Delete completed items process

        string deleteItemsButtonXPath = "//a[@id='DoneItemsDeleteLink']";

        var deleteItemsButton = ChromeFixture.ChromeDriver.FindElement(
            By.XPath(deleteItemsButtonXPath)
        );
        deleteItemsButton.Click();
        var alert1 = ChromeFixture.ChromeDriver.SwitchTo().Alert();
        alert1.Accept();

        /* Delete project process
        string projectDivXPath = $"//td[text()='{tempProjectName}']/following::td[1]";
        string deleteContextButtonXPath =
            $"//td[text()='{tempProjectName}']/following::td[1]/div[contains(@style,'block')]/img";
        string deleteProjectButtonXPath = "//a[contains(@id,'ProjShareMenuDel')]";

        var projectDiv = ChromeFixture.ChromeDriver.FindElement(By.XPath(projectDivXPath));
        Actions actions = new Actions(ChromeFixture.ChromeDriver);
        actions.MoveToElement(projectDiv).Perform();

        var deleteContextButton = ChromeFixture.ChromeDriver.FindElement(
            By.XPath(deleteContextButtonXPath)
        );
        deleteContextButton.Click();

        var deleteProjectButton = ChromeFixture.ChromeDriver.FindElement(
            By.XPath(deleteProjectButtonXPath)
        );

        deleteProjectButton.Click();
        var alert2 = ChromeFixture.ChromeDriver.SwitchTo().Alert();
        alert2.Accept();

        /* Logout process

        string logoutButtonXPath = "//a[@id='ctl00_HeaderTopControl1_LinkButtonLogout']";

        var logoutButton = ChromeFixture.ChromeDriver.FindElement(By.XPath(logoutButtonXPath));
        logoutButton.Click();


        string currentUrl = ChromeFixture.ChromeDriver.Url;

        Assert.Equal(expected: _siteUrl, actual: currentUrl);
    }
}

*/
