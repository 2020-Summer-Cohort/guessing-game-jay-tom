using System;

namespace GuessingGame
{
    class Program
    {
        static int badGuesses = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guessing Game!");

            bool keepThinking = true;
            while (keepThinking)
            {
               
                
                IterationFour();

                if(badGuesses < 2)
                Console.WriteLine("Do you want to play again?\n");
                
                string userChoice = Console.ReadLine().ToLower();
                bool isFirstCharacterY = userChoice.ToLower().StartsWith("y");

                if (!isFirstCharacterY || badGuesses == 2)
                       keepThinking = false;

            }

            //method
            static void IterationFour()
            {


                Console.WriteLine("Guess a number 1-10");
                string inputValue = Console.ReadLine();

                if (inputValue == "0")
                {
                    
                    //Long form
                    badGuesses = badGuesses + 1;
                    Console.WriteLine("You entered an invalid value. Please enter numbers in the range from 1-10. Bad guess count " + badGuesses);

                }
                else if (inputValue == "-1")
                {
                    Console.WriteLine("Immediate shutdown NOW!!!");
                    badGuesses = 2;  //Set the bad guesses to maximum so the program will shutdown per requirements

                }


                else if (inputValue == "7")
                {
                    Console.WriteLine("You Win!");

                    if(badGuesses > 0)
                        badGuesses = -1;
                }

                else
                {
                    Console.WriteLine("You Lose!");
                    badGuesses = +1;  //Short form, ternary operator
                }
                
                

            }
        }
    }
}

