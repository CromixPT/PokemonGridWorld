using WorldLibrary.Models;

namespace WorldLibrary
{
    public class GameWorld
    {
        public static int PokemonsCaught { get; set; }

        public static int ProcessPlay(string input)
        {
            PositionModel currentPosition = new PositionModel();

            //Already caught pokemon in first position(0,0)
            PokemonsCaught = 1;


            //List<char> inputChars = StringProcessor.ProcessString(input);

            foreach(char letter in input)
            {
                if(StringProcessor.isCharacterValid(letter))
                {
                    currentPosition = MovementProcessor.Movement(currentPosition, letter);
                }

            }

            return PokemonsCaught;

        }
    }
}
