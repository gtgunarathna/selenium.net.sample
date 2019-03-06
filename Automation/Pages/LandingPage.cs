using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Automation.Pages
{
    class LandingPage
    {
        private readonly IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ctl13_Register\"]")]
        public IWebElement RegisterLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ctl13_Login\"]")]
        public IWebElement LoginLink { get; set; }


        public LandingPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ClickRegister()
        {
            RegisterLink.Click();
        }

        public void ClickLogin()
        {
            LoginLink.Click();
        }
    }
}
