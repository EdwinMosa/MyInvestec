using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MyInvestec;

namespace UnitTest
{
    public class NumberOfVowelsTest
    {

        [Test]
        public void CheckNumberOfUniqueVowels()
        {
            // Arange
            string strUserInput = "I like eating apples";
            strUserInput = Regex.Replace(strUserInput, @"\s", "");
            // Act
            string strResults = Vowels.Count(strUserInput);

            // Assert
            Assert.AreEqual("Your total number of vowels is 3", strResults);
        }


        [Test]
        public void CheckNumberOfNonVowels()
        {
            // Arange
            string strUserInput = "jkl kkjh";
            strUserInput = Regex.Replace(strUserInput, @"\s", "");
            // Act
            string strResults = Vowels.Count(strUserInput);

            // Assert
            Assert.AreEqual("No vowels were found", strResults);
        }

        [Test]
        public void CheckIfMoreVowels()
        {
            // Arange
            string strUserInput = "I eat";
            strUserInput = Regex.Replace(strUserInput, @"\s", "").ToLower();
            // Act
            string strResults = Output.Message(strUserInput);

            // Assert
            Assert.AreEqual("The text has more vowels than non vowels", strResults);
        }

        [Test]
        public void CheckIfMoreNonVowels()
        {
            // Arange
            string strUserInput = "that dog";
            strUserInput = Regex.Replace(strUserInput, @"\s", "");
            // Act
            string strResults = Output.Message(strUserInput);

            // Assert
            Assert.AreEqual("The text has more non vowels than vowels", strResults);
        }


        [Test]
        public void CheckIfVowelsEqualsNonVowels()
        {
            // Arange
            string strUserInput = "3 a";
            strUserInput = Regex.Replace(strUserInput, @"\s", "");
            // Act
            string strResults = Output.Message(strUserInput);

            // Assert
            Assert.AreEqual("The text has an equal amount of vowels and non vowels", strResults);
        }
    }
}
