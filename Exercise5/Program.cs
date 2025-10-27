using System;

class Program
{
    static void Main()
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squared = SquareNumber(favoriteNumber);
        DisplayResult(userName, squared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name ?? "";
    }

    static int PromptUserNumber()
    {
        while (true)
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("That's not a valid integer. Try again.");
            }
        }
    }

    static int SquareNumber(int value)
    {
        return value * value;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
