using System;
using WorldLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            GameWorld Game = new GameWorld();

            Console.WriteLine("Welcome to Pokemon Grid World");
            Console.WriteLine("Provide me with a set of cardinal instructions(N,S,E,O) and we will see how many pokemon Ash picks!");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.Write("Input: ");
            string input = Console.ReadLine();


            Game.Play(input);


            Console.WriteLine($"\nAsh caught {Game.PokemonsCaught} pokemons\n\n");

        }
    }
}
