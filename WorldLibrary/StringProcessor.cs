using System.Linq;

namespace WorldLibrary
{
    public class StringProcessor
    {
        static char[] validChars = { 'N', 'S', 'E', 'O' };

        public static bool isCharacterValid(char inputChar)
        {
            if(!validChars.Contains(inputChar))
            {
                return false;
            }
            return true;
        }

        //public static List<char> ProcessString(string input)
        //{
        //    List<char> inputChars = new List<char>();

        //    foreach(char letter in input)
        //    {
        //        if(StringProcessor.isCharacterValid(letter))
        //        {
        //            inputChars.Add(letter);
        //        }

        //    }

        //    return inputChars;
        //}

    }
}
