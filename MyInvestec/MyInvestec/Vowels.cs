using System;
using System.Linq;

namespace MyInvestec
{
    public static class Vowels
    {
        // Here are vowels in lower case, user input is already converted to lower case.
        static readonly char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        public static int CountUniqueVowels(string strInput)
        {
            return strInput.Distinct().Count(c => vowels.Contains(c));
        }

        public static int CountUniqueNonVowels(string strInput)
        {
            return strInput.Distinct().Count(c => !vowels.Contains(c));
        }


        public static string Count(string strInput)
        {
            int intTotal = CountUniqueVowels(strInput);
            string strResults;

            if (intTotal > 0)
            {
                strResults = $"Your total number of vowels is {intTotal}";
                Console.WriteLine(strResults);
            }
            else
            {
                strResults = "No vowels were found";
                Console.WriteLine(strResults);
            }

            return strResults;
        }
    }
}
