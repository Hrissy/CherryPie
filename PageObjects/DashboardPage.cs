using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace Tests.PageObjects
{
    public class DashboardPage : BasePage
    {
        public DashboardPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h1[class *= 'PageHeader']")]        private IWebElement Header { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[class *= 'SideNav']")]        private IWebElement PageContent { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Sales')]")]        private IWebElement SalesBtn { get; set; }

        public string HeaderText => Header.Text;

        public void ClickSalesBtn()
        {
            SalesBtn.Click();
        }
    }
}
