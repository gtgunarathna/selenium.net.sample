using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Util
{
    static class StringUtil
    {

        public static string GetString(List<string> stringList, string concatinator)
        {
            string returnString = "";
            foreach (string str in stringList)
            {
                returnString = returnString + str + concatinator;
            }
            return returnString;
        }

        public static string GetUnique()
        {
            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            return milliseconds.ToString();
        }

        public static string GetRandomNo(int maxNumber)
        {
            Random random = new Random();
            return random.Next(maxNumber).ToString();
        }

        public static int GetRandomInt(int maxNumber)
        {
            Random random = new Random();
            return random.Next(maxNumber);
        }
    }
}
