using WorldLibrary.Models;

namespace WorldLibrary
{
    public class MovementProcessor
    {
        internal static PositionModel Move(PositionModel currentPosition, char letter)
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
