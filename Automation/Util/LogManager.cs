using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Util
{
    class LogManager
    {
        public static log4net.ILog GetLogger(System.Type type)
        {
            log4net.ILog logger = log4net.LogManager.GetLogger(type);
            XmlConfigurator.Configure();
            return logger;
        }

        public static log4net.ILog GetExLogger()
        {
            log4net.ILog logger = log4net.LogManager.GetLogger("ExecutionAppender");
            XmlConfigurator.Configure();
            return logger;
        }
    }
}
