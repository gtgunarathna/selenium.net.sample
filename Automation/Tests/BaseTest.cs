using Automation.Util;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Automation.Tests
{

    class BaseTest
    {

        static protected IWebDriver driver;
        static protected readonly String userName = "John_" + StringUtil.GetUnique();
        static protected readonly String password = "Ousl2018";
        static protected readonly String age = "35";


    }
}
