using System;
using System.Text.RegularExpressions;

namespace MyInvestec
{
    public class DataCapture
    {
        public static string GetUserText()
        {
            //Get user input
            string strIn = Console.ReadLine().ToLower();
            // Remove spaces from the input
            strIn = Regex.Replace(strIn, @"\s", "");
            return strIn;
        }

        public static string GetUserOption()
        {
            //Get user options
            string userOption = Console.ReadLine();
            // Remove spaces from the input
            userOption = Regex.Replace(userOption, @"\s", "");
            return userOption;
        }
    }
}
