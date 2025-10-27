using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int value))
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;
            }

            if (value == 0)
                break;

            numbers.Add(value);
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        // Sum
        int sum = 0;
        int max = numbers[0];
        foreach (int n in numbers)
        {
            sum += n;
            if (n > max) max = n;
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // --- Stretch: smallest positive number and sorted list ---
        // Find smallest positive number (closest to zero, but > 0)
        int? smallestPositive = null;
        foreach (int n in numbers)
        {
            if (n > 0)
            {
                if (smallestPositive == null || n < smallestPositive) smallestPositive = n;
            }
        }

        if (smallestPositive != null)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}
