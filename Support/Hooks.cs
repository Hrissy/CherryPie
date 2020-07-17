using System;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;


namespace Tests.Support
{
    [Binding]
    public class Hooks
    {
         IWebDriver driver;

        private readonly IObjectContainer objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            objectContainer.RegisterInstanceAs<IWebDriver>(driver);
            driver.Manage().Window.Maximize();
        }


        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

    }
}
