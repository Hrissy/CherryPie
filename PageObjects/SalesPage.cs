using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Tests.PageObjects
{
    public class SalesPage : BasePage
    {
        public SalesPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "div[class *= 'InfoScreenContainer'] > div > h2")]        private IWebElement MessageNoResults { get; set; }

        public string MessageNoResultsText => MessageNoResults.Text;
    }
}
