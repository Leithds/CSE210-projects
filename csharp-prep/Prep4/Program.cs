using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        int number;

        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        int sum = 0;

        int largestNumber = int.MinValue;

        foreach (int num in numbers)
        {
            sum += num;

            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }

        float average = (float)sum / numbers.Count;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Largest Number: {largestNumber}");
        Console.WriteLine($"Average: {average}");
    }
}