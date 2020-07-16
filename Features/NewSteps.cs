
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Tests.Helpers;
using Tests.PageObjects;

[Binding]
public class StepDefinitions

{
    readonly ScenarioContext scenarioContext;
    readonly LogIn logIn;
    readonly BasePage basePage;


    public StepDefinitions(ScenarioContext scenarioContext, LogIn logIn, BasePage basePage)
    {
        this.logIn = logIn;
        this.basePage = basePage;
        this.scenarioContext = scenarioContext;
    }

    [Given(@"have opened url")]
    public void GivenHaveOpenedUrl()
    {
        basePage.OpenURL();
    }

    [Given(@"test user is logged in")]
    public void GivenTestUserIsLoggedIn()
    {
        //_scenarioContext.Pending();
    }
}