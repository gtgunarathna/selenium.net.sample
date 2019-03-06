using Automation.Pages;
using Automation.Util;
using NUnit.Framework;
using System;


namespace Automation.Tests
{
    [TestFixture, Order(1)]
    class RegisterTest : BaseTest
    {
        LandingPage landingPage;
        RegisterPage registerPage;
        DashboardPage dashboard;
        protected static log4net.ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [Test]
        public void RegisterUser()
        {
            logger.Info("Starting Register Test");
            landingPage = new LandingPage(driver);

            landingPage.ClickRegister();
            registerPage = new RegisterPage(driver);

            registerPage.TypeUserName(userName);
            registerPage.TypeAge(age);
            registerPage.TypePassword(password);
            registerPage.TypeConfirmPassword(password);
            registerPage.ClickRegister();
            dashboard = new DashboardPage(driver);

            String welcomeMessage = dashboard.GetWelcomeMessage();
            Assert.IsTrue(welcomeMessage.Contains(userName), "Expected :" + userName + " Actual: " + welcomeMessage);
            dashboard.ClickLogoff();
        }
    }
}
