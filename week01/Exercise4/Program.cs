using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a series of numbers. Enter 0 to stop:");

        int userNumbers = -1;

        while (userNumbers !=0)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            userNumbers = int.Parse(input);

            if (userNumbers !=0)
            {
                numbers.Add(userNumbers);
            }
        }
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The sum is: {total}");

        int average= -1;
        int numbersCount = numbers.Count;

        average= total/numbersCount;

        Console.WriteLine($"The average is: {average}");        

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)

            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}