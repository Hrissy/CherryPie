using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support;
using Tests.Helpers;

namespace Tests.PageObjects
{
    public class LogIn : BasePage
    {
        public LogIn (IWebDriver driver): base(driver)
        {
           PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#loader")]        private IWebElement Loader { get; set; }

        public void DoSmth()
        {
            Loader.Click();
        }
    }
}
