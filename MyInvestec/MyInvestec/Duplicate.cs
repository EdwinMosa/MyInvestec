using System;
using System.Linq;

namespace MyInvestec
{
    public class Duplicate
    {
        public static string Check(string strInput)
        {
            //convert the input string into an array so you can loop through
            char[] arrInput = strInput.ToCharArray();
            string strCheck = string.Empty;
            string strResults;

            var duplicates = arrInput
                .GroupBy(p => p)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key);

            foreach (var item in duplicates)
            {
                strCheck += item;
            }

            // Display the results
            if (duplicates.Count() > 0)
            {
                strResults = $"Found the following duplicates: {strCheck}";
                Console.WriteLine(strResults);
            }
            else
            {
                strResults = "No duplicate values were found";
                Console.WriteLine(strResults);
            }

            return strResults;
        }
    }
}
