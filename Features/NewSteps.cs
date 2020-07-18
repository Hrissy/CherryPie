
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Tests.PageObjects;

[Binding]
public class StepDefinitions

{
    readonly ScenarioContext scenarioContext;
    readonly LogInPage logInPage;
    readonly BasePage basePage;
    readonly DashboardPage dashboardPage;
    readonly SalesPage salesPage;


    public StepDefinitions(ScenarioContext scenarioContext, LogInPage logIn, BasePage basePage, DashboardPage dashboardPage, SalesPage salesPage)
    {
        this.logInPage = logIn;
        this.basePage = basePage;
        this.dashboardPage = dashboardPage;
        this.salesPage = salesPage;

        this.scenarioContext = scenarioContext;
    }

    [Given(@"Have opened SumUp url")]
    public void GivenHaveOpenedUrl()
    {
        basePage.OpenURL();
    }

    [Given(@"Test user has logged in")]
    public void GivenTestUserIsLoggedIn()
    {
        logInPage.DoLogIn();
    }

    [StepDefinition(@"Page ""(.*)"" has loaded")]
    public void GivenPageHasLoaded(string name)
    {
        Assert.AreEqual(dashboardPage.HeaderText, name);
    }

    [When(@"Sales tab is selected")]
    public void WhenSalesTabIsSelected()
    {
        dashboardPage.ClickSalesBtn();
    }

    [Then(@"Message ""(.*)"" is displayed")]
    public void ThenMessageIsDisplayed(string message)
    {
        Assert.AreEqual(salesPage.MessageNoResultsText, message);
    }
}