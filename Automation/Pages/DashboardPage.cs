using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Pages
{
    class DashboardPage
    {
        private readonly IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ctl01\"]/div[3]/div/div[2]/ul[2]/li[2]/a")]
        public IWebElement LogOffLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ctl01\"]/div[3]/div/div[2]/ul[2]/li[1]/a")]
        public IWebElement WelcomeMessage { get; set; }

        public DashboardPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public DashboardPage ClickLogoff()
        {
            LogOffLink.Click();
            return this;
        }

        public String GetWelcomeMessage()
        {

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            IWebElement welcomeMsgElement = wait.Until(ExpectedConditions.ElementToBeClickable(WelcomeMessage));
            String welcome = welcomeMsgElement.Text;
            return welcome;
        }

    }
}
