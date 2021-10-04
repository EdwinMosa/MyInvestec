using System;
using System.Linq;

namespace MyInvestec
{
    class Program
    {

        static readonly Char[] userMenu = { '1', '2', '3' };
        static void Main(string[] args)
        {
            try
            {
                GenericMessages.WelcomeMessage();

                User user = new();
                user.UserIput = DataCapture.GetUserText();

                do
                {
                    // Show user actions to be performed
                    GenericMessages.DisplayUserOptions();

                    user.UserOption = DataCapture.GetUserOption();

                    // Now that you have an otion from user, take action
                    DisplayResults.Message(user.UserOption, user.UserIput);

                } while (user.UserOption.Any(c => userMenu.Contains(c)));

                GenericMessages.CloseApplication();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops, something went wrong: " + ex.Message);
                GenericMessages.CloseApplication();
            }
        }
    }
}
