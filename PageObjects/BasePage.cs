using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;

namespace Tests.Helpers
{
    public class BasePage
    {
        IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenURL()
        {
            driver.Navigate().GoToUrl(Constants.url);
        }

 
    }
}
