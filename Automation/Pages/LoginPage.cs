using Automation.Util;
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
    class LoginPage
    {
        private readonly IWebDriver _driver;
        protected static log4net.ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [FindsBy(How = How.XPath, Using = "//*[@id=\"loginForm\"]/div/div[4]/div/input")]
        public IWebElement LoginButtion { get; set; }

        [FindsBy(How = How.Id, Using = "MainContent_UserName")]
        public IWebElement UserNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "MainContent_Password")]
        public IWebElement PasswordInput { get; set; }

       public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void typeUserName(String userName)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            IWebElement userNameElement = wait.Until(ExpectedConditions.ElementToBeClickable(UserNameInput));
            userNameElement.SendKeys(userName);
        }
    
        public void TypePassword(String password)
        {
        PasswordInput.SendKeys(password);
        }

        public void ClickLogin()
        {
            LoginButtion.Click();
        }
    }
}
