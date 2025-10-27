using System;

class Program
{
    static void Main()
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.Write("What is your favorite number? ");
        string numberInput = Console.ReadLine();

        int favoriteNumber = int.Parse(numberInput);

        Console.WriteLine();
        Console.WriteLine($"Hello {firstName} {lastName}!");
        Console.WriteLine($"Your favorite number is {favoriteNumber}.");
        Console.WriteLine($"Did you know that {favoriteNumber} squared is {favoriteNumber * favoriteNumber}?");
    }
}
