using System;
using WorldLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Pokemon Grid World");
            Console.WriteLine("Ash will move with your instructions, provide me with a set of cardinal instructions(N,S,E,O) and we see how many pokemon Ash picks!");

            string input = Console.ReadLine().ToUpper();


            int PokemonsCaught = GameWorld.ProcessPlay(input);


            Console.WriteLine($"Ash caught {PokemonsCaught} pokemons");

        }
    }
}
