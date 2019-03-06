using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Util
{
    class ConfigurationData
    {
        public static string URL
        {
            get
            {
                return ConfigurationManager.AppSettings[Constants.TestSettings.URL].ToString();
            }
        }
        public static string Browser
        {
            get
            {
                return ConfigurationManager.AppSettings[Constants.TestSettings.Browser].ToString();
            }
        }
        public static string DriverLocation
        {
            get
            {
                return ConfigurationManager.AppSettings[Constants.TestSettings.DriverLocation].ToString();
            }
        }
    }
}
