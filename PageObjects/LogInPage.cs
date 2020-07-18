using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support;
using Tests.Support;

namespace Tests.PageObjects
{
    public class LogInPage : BasePage
    {
        public LogInPage (IWebDriver driver): base(driver)
        {
           PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#username")]        private IWebElement UsernameInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#password")]        private IWebElement PasswordInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button[data-selector='LOGIN.LOGIN_BUTTON']")]        private IWebElement LogInBtn { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[class~='Box-Login']")]        private IWebElement LogInForm { get; set; }

        public void DoLogIn()
        {
            UsernameInput.SendKeys(Constants.username);
            PasswordInput.SendKeys(Constants.password);
            LogInBtn.Click();
        }
    }
}
