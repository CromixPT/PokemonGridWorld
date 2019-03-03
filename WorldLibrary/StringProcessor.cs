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
    }
}
