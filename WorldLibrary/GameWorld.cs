namespace WorldLibrary
{
    public class GameWorld
    {
        public static int PokemonsCaught { get; set; }

        public static int ProcessPlay(string input)
        {
            //Already caught pokemon in first position(0,0)
            PokemonsCaught = 1;


            return PokemonsCaught;

        }
    }
}
