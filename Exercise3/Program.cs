using System;

class Program
{
    static void Main()
    {
        Random randomGenerator = new Random();
        string playAgain;

        do
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("Welcome to the Guess My Number game!");
            Console.WriteLine("I have picked a number between 1 and 100.");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} tries!");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing!");
    }
}
