using System;
using WorldLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Pokemon Grid World");
            Console.WriteLine("Provide me with a set of cardinal instructions(N,S,E,O) and we see how many pokemon Ash picks!");

            string input = Console.ReadLine();


            int PokemonsCaught = GameWorld.Play(input);


            Console.WriteLine($"Ash caught {PokemonsCaught} pokemons");

        }
    }
}
