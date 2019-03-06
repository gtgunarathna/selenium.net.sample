using Automation.Util;
using NUnit.Framework;


namespace Automation.Tests
{
    [SetUpFixture]
    class SetUpFixtureTest : BaseTest
    {
        [OneTimeSetUp]
        public void BeforeSuite()
        {
            driver = WebDriverUtil.GetDriver();
        }

        [OneTimeTearDown]
        public void AfterSuite()
        {
            driver.Quit();
        }
    }
}
