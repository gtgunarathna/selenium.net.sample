using Automation.Pages;
using Automation.Util;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation.Tests
{
    [TestFixture, Order(2)]
    class LoginTest : BaseTest
    {
        LandingPage landingPage;
        DashboardPage dashboard;
        LoginPage loginPage;
        protected static log4net.ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
               
        [Test]
        public void LoginRegisteredUser()
        {
            logger.Info("Starting Login Test");
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
