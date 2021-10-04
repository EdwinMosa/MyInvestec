using MyInvestec;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace UnitTest
{
    public class CheckDuplicatesTests
    {       

        [Test]
        public void Check_Duplicates_Found()
        {
            // Arange
            string strUserInput = "I like eating apples";
            strUserInput = Regex.Replace(strUserInput, @"\s", "").ToLower();
            // Act
            string strResults = Duplicate.Check(strUserInput);

            // Assert
            Assert.AreEqual("Found the following duplicates: ileap", strResults);
        }

        [Test]
        public void Check_Duplicates_NotFound()
        {
            // Arange
            string strUserInput = "abcd4";
            strUserInput = Regex.Replace(strUserInput, @"\s", "");
            // Act
            string strResults = Duplicate.Check(strUserInput);

            // Assert
            Assert.AreEqual("No duplicate values were found", strResults);
        }
    }
}