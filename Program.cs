using System;
using System.Dynamic;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var favNumber = 7;

            Console.WriteLine("Guess my favorite number");

            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favNumber)
            {
                Console.WriteLine("TOO LOW!");
            }
            else if (userGuess > favNumber)
            {
                Console.WriteLine("TOO HIGH");
            }
            else if (userGuess == favNumber)
            {
                Console.WriteLine("YOU WIN");
            }
            else
            {
                Console.WriteLine("NeverMind");
            }
          */
            Console.WriteLine("What is your favorite school subject?");
                string answer = Console.ReadLine();
            
            switch (answer)
            {
                case "History":
                    Console.WriteLine("You are in the History Class!");
                    break;
                case "Math":
                    Console.WriteLine("Math is great!");
                    break;
                case "Art":
                    Console.WriteLine("Art is great!");
                    break;
                case "P.E.":
                    Console.WriteLine("P.E. is great!");
                    break;
                case "English":
                    Console.WriteLine("English is great!");
                    break;
                default:
                    Console.WriteLine("We dont teach that here");
                    break;
            }




            
            

        }
    }
}
