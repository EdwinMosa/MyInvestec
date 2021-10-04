namespace MyInvestec
{
    public class DisplayResults
    {

        public static void Message(string strAction, string strInput)
        {
            //put selected options/actions in an array
            char[] option = strAction.ToCharArray();

            foreach (var item in option)
            {
                if (item.ToString() == "1")
                {
                    Duplicate.Check(strInput);
                }
                else if (item.ToString() == "2")
                {
                    Vowels.Count(strInput);
                }
                else if (item.ToString() == "3")
                {
                    Output.Message(strInput);
                }
            }
        }
    }
}
