using Automation.Pages;
using Automation.Tests;
using Automation.Util;
using NUnit.Framework;
using System;


namespace Automation.Tests
{
    [TestFixture, Order(3)]
    class RegistrationTest : BaseTest
    {
        LandingPage landingPage;
        RegisterPage registerPage;
        DashboardPage dashboard;
        new String userName = "John_" + StringUtil.GetUnique();
        protected static log4net.ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        LoginPage loginPage;

        [OneTimeSetUp]
        public void BeforeClass()
        {
            logger.Info("Starting Registration Test");
            landingPage = new LandingPage(driver);
        }

        [Test, Order(1)]
        public void RegisterUser()
        {
            logger.Info("Start of Register Test");

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

        [Test, Order(2)]
        public void LoginRegisteredUser()
        {
            logger.Info("Start Login Test");

            landingPage = new LandingPage(driver);

            landingPage.ClickLogin();
            loginPage = new LoginPage(driver);

            loginPage.typeUserName(userName);
            loginPage.TypePassword(password);
            loginPage.ClickLogin();
            dashboard = new DashboardPage(driver);

            String welcomeMessage = dashboard.GetWelcomeMessage();
            Assert.IsTrue(welcomeMessage.Contains(userName), "Expected :" + userName + " Actual: " + welcomeMessage);
            dashboard.ClickLogoff();
        }

    }
}
