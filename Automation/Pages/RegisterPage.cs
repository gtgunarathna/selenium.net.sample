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
    class RegisterPage
    {
        private readonly IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "MainContent_UserName")]
        public IWebElement UserNameInput { get; set; }
        [FindsBy(How = How.Id, Using = "MainContent_Age")]
        public IWebElement AgeInput { get; set; }
        [FindsBy(How = How.Id, Using = "MainContent_Password")]
        public IWebElement PasswordInput { get; set; }
        [FindsBy(How = How.Id, Using = "MainContent_ConfirmPassword")]
        public IWebElement ConfirmPasswordInput { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"ctl01\"]/div[4]/div/div[6]/div/input")]
        public IWebElement RegisterButton { get; set; }

        public RegisterPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void TypeUserName(String userName)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            IWebElement userNameElement = wait.Until(ExpectedConditions.ElementToBeClickable(UserNameInput));
            userNameElement.SendKeys(userName);
        }

        public void TypeAge(String age)
        {
           AgeInput.SendKeys(age);
        }

        public void TypePassword(String password)
        {
            PasswordInput.SendKeys(password);
        }

        public void TypeConfirmPassword(String password)
        {
            ConfirmPasswordInput.SendKeys(password);
        }

        public void ClickRegister()
        {
            RegisterButton.Click();
        }
    }
}
