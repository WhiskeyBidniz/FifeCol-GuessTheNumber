using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
              
namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            string restartResponse = "y";





            while (restartResponse == "y")
            {
                Console.WriteLine("Guess The Number");
                Console.WriteLine("By Owen Penman");
                Console.WriteLine("");
                Console.WriteLine("Guess a random number that's generated by the PC between 1 and 10!");
                Random rand = new Random();
                int Guesses = 0;
                int secretNumber = rand.Next(1, 10);

                //Console.WriteLine("Secret Number is " + secretNumber);


                int playerInput = Convert.ToInt32(Console.ReadLine());
                Guesses++;



                while (playerInput != secretNumber & Guesses < 10 )
                {



                    Console.WriteLine("You guessed " + playerInput);
                    if (playerInput == secretNumber)
                    {
                        Console.WriteLine("Congrats You guessed correct! The number was " + secretNumber);
                    }
                    else
                    {
                        Console.WriteLine("Sorry! You didn't guess the right number. Try Again!");

                        if (secretNumber < playerInput)
                        {
                            Console.WriteLine("Aim Lower!");
                        }
                        else
                        {
                            Console.WriteLine("Aim Higher!");
                        }

                        playerInput = Convert.ToInt32(Console.ReadLine());
                        ++Guesses;
                    }

                   

                }

                if (Guesses == 10)
                {
                    Console.WriteLine("OUT OF GUESSES. YOU LOSE!");
                    Console.WriteLine("THE NUMBER WAS: " + secretNumber);
                    Console.WriteLine("Do you want to try again? (y/n) ");
                    restartResponse = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Congrats You guessed correct! The number was " + secretNumber);
                    Console.WriteLine("You did this in " + Guesses + " tries!");

                    Console.WriteLine("Do you want to play again? (y/n)");




                    restartResponse = Console.ReadLine();

                }


            }
            
            
            
                Console.WriteLine("Thanks for playing! Press a key to close!");
                Console.ReadKey();
            



            

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

