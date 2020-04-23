using System;

namespace Number_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();

            int easyNumber = randomNumber.Next(1,10);
            int mediumNumber = randomNumber.Next(1,20);
            int hardNumber = randomNumber.Next(1,50);
            string level;
            int guess = 0;
            int tries = 0;

            bool play = true;
            
            while (play)
            {
                Console.WriteLine("Welcome to this Number Guessing Game!!!");
                Console.WriteLine();

                Console.Write("Enter level; Easy, Medium or Hard: ");
                level = Console.ReadLine();

                if(level.ToUpper() == "EASY") 
                {
                    tries = 6;
                    while(tries != 0)
                    {
                        Console.Write("Guess a number between 1 and 10: ");
                        guess = int.Parse(Console.ReadLine());
                        if(guess < 1 || guess > 10)
                        {
                        Console.WriteLine("Invalid Number");
                        }
                        else if(guess == easyNumber)
                        {
                            Console.WriteLine("You got it right");
                            break;
                        }
                        else {
                            Console.WriteLine("That was wrong");
                            }
                        tries -= 1;
                        Console.WriteLine("You have {0} attempt left", tries);
                        if(tries == 0)
                        {
                            Console.WriteLine("Game Over!");
                        }
                    }  
                }
                if(level.ToUpper() == "MEDIUM")
                {
                    tries = 4;
                    while(tries != 0)
                    {
                        Console.Write("Guess a number between 1 and 20: ");
                        guess = int.Parse(Console.ReadLine());
                        if(guess < 1 || guess > 20)
                        {
                            Console.WriteLine("Invalid Number");
                        }
                        else if(guess == mediumNumber)
                        {
                            Console.WriteLine("You got it right");
                            break;
                        }
                        else {
                            Console.WriteLine("That was wrong");
                        }
                        tries -= 1;
                        Console.WriteLine("You have {0} attempt left", tries);
                        if(tries == 0)
                        {
                            Console.WriteLine("Game Over!");
                        }
                    }
                }
                if(level.ToUpper() == "HARD")
                {
                    tries = 3;
                    while(tries != 0)
                    {
                        Console.Write("Guess a number between 1 and 50: ");
                        guess = int.Parse(Console.ReadLine());
                        if(guess < 1 || guess > 50)
                        {
                            Console.WriteLine("Invalid Number");
                        }
                        else if(guess == hardNumber)
                        {
                            Console.WriteLine("You got it right");
                            break;
                        }
                        else {
                            Console.WriteLine("That was wrong");
                        }
                        tries -= 1;
                        Console.WriteLine("You have {0} attempt left", tries);
                        if(tries == 0)
                        {
                            Console.WriteLine("Game Over!");
                        }
                    }
                }
                Console.Write("Would you like to play again? Yes/No: ");
                string play_again = Console.ReadLine();
                if (play_again.ToUpper() == "NO")
                {
                    play = false;
                    Console.WriteLine("Thanks for playing the game!");
                }
                else {
                    play = true;
                }
            }

            
        }
    }
}
