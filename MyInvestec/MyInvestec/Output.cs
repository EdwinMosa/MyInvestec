using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInvestec
{
    public static class Output
    {

        public static string Message(string strInput)
        {
            int vowel = Vowels.CountUniqueVowels(strInput);
            int nonVowel = Vowels.CountUniqueNonVowels(strInput);
            string strResults;

            if (nonVowel == vowel)
            {
                strResults = "The text has an equal amount of vowels and non vowels";
                Console.WriteLine(strResults);
            }
            else if (nonVowel > vowel)
            {
                strResults = "The text has more non vowels than vowels";
                Console.WriteLine(strResults);
            }
            else
            {
                strResults = "The text has more vowels than non vowels";
                Console.WriteLine(strResults);
            }

            return strResults;
        }
    }
}
