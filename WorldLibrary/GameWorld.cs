using System.Collections.Generic;
using System.Linq;
using WorldLibrary.Models;

namespace WorldLibrary
{
    public class GameWorld
    {
        public int PokemonsCaught { get; set; }

        public int Play(string input)
        {
            PositionModel currentPosition = new PositionModel();
            var dicPositionsVisited = new Dictionary<string, bool>();

            //Already caught pokemon in first position(0,0)
            PokemonsCaught = 1;
            dicPositionsVisited[$"{currentPosition.xValue},{currentPosition.yValue}"] = true;

            //make sure we only dealing with uppercase
            input = input.ToUpper();

            foreach(char letter in input)
            {
                if(IsCharacterValid(letter))
                {
                    Move(currentPosition, letter);

                    //if first time in this position add it to dictionary and catch the pokemon
                    if(!dicPositionsVisited.ContainsKey($"{currentPosition.xValue},{currentPosition.yValue}"))
                    {
                        dicPositionsVisited[$"{currentPosition.xValue},{currentPosition.yValue}"] = true;
                        PokemonsCaught++;
                    }
                }

            }
            return PokemonsCaught;

        }

        //validates if input character is valid
        private bool IsCharacterValid(char inputChar)
        {

            char[] validChars = { 'N', 'S', 'E', 'O' };
            if(!validChars.Contains(inputChar))
            {
                return false;
            }
            return true;
        }


        //movement is based on a XX's YY's axis
        private PositionModel Move(PositionModel currentPosition, char letter)
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
