using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guessing Game!");

            bool keepThinking = true;
            while (keepThinking)
            {
                IterationOne();
                Console.WriteLine("Do you want to play again?\n");
                string userChoice = Console.ReadLine().ToLower();

                if (userChoice != "yes")
                    keepThinking = false;

            }

            //method
            static void IterationOne()
            {


                Console.WriteLine("Guess a number 1-10");
                string inputValue = Console.ReadLine();

                if (inputValue == "7")
                {
                    Console.WriteLine("You Win!");

                }
                else
                {
                    Console.WriteLine("You Lose!");
                }
                Console.WriteLine("Press Enter To Return");

            }
        }
    }
}

