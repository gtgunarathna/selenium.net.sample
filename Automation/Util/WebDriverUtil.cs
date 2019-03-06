using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Util
{
    static class WebDriverUtil
    {
        public static IWebDriver GetDriver()
        {

            IWebDriver driver;
            String browser = ConfigurationData.Browser;
            String driverLocation = ConfigurationData.DriverLocation;

            switch (browser)
            {
                case "Chrome":
                    {
                        driver = new ChromeDriver(driverLocation); ;
                        break;
                    }
                case "Firefox":
                    {
                        driver = new FirefoxDriver(driverLocation);
                        break;
                    }
                default:
                    {
                        driver = new ChromeDriver(driverLocation); ;
                        break;
                    }
            }
            driver.Url = ConfigurationData.URL;
            return driver;
        }

    }
}
