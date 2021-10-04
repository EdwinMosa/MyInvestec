using System;

namespace MyInvestec
{
    public class GenericMessages
    {

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my C# console application!");
            Console.WriteLine("\nEnter text to be analysed: ");
        }


        public static void DisplayUserOptions()
        {
            Console.WriteLine("\nEnter which operations to do on the supplied text, \n" +
                " 1. for a duplicate character check, \n" +
                " 2. to count the number of vowels, \n" +
                " 3. to check if there are more vowels or non vowels, \n" +
                " or any combination of 1, 2 and 3 to perform multiple checks:\n");


        }
        public static void CloseApplication()
        {
            Console.WriteLine("Good bye, press Enter to exit...");
            Console.ReadLine();
        }

    }
}
