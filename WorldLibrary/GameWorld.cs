using System.Collections.Generic;
using System.Linq;
using WorldLibrary.Models;

namespace WorldLibrary
{
    public class GameWorld
    {
        public static int PokemonsCaught { get; set; }

        public static int Play(string input)
        {
            PositionModel currentPosition = new PositionModel();
            var dicPositionsVisited = new Dictionary<string, bool>();

            //Already caught pokemon in first position(0,0)
            PokemonsCaught = 1;
            dicPositionsVisited[$"{currentPosition.xValue},{currentPosition.yValue}"] = true;

            input = input.ToUpper();

            foreach(char letter in input)
            {
                if(IsCharacterValid(letter))
                {
                    currentPosition = Move(currentPosition, letter);
                }

                if(!dicPositionsVisited.ContainsKey($"{currentPosition.xValue},{currentPosition.yValue}"))
                {
                    dicPositionsVisited[$"{currentPosition.xValue},{currentPosition.yValue}"] = true;
                    PokemonsCaught++;
                }
            }

            return PokemonsCaught;

        }

        private static bool IsCharacterValid(char inputChar)
        {
            char[] validChars = { 'N', 'S', 'E', 'O' };
            if(!validChars.Contains(inputChar))
            {
                return false;
            }
            return true;
        }

        private static PositionModel Move(PositionModel currentPosition, char letter)
        {
            var newPostion = currentPosition;
            switch(letter)
            {
                case 'N':
                    newPostion.xValue++;
                    break;
                case 'S':
                    newPostion.xValue--;
                    break;
                case 'E':
                    newPostion.yValue++;
                    break;
                case 'O':
                    newPostion.yValue--;
                    break;
                default:
                    break;
            }
            return newPostion;
        }
    }
}
