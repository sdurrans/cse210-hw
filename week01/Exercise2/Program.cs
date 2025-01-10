using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int grade =int.Parse(userGrade);
        string letter = "";

        if (grade >= 90)
        {
            letter= "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter= "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter= "AC";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter= "D";
        }
        else 
        {
            letter= "F";
        }
        Console.WriteLine($"Your letter grade is {letter}");

        if (grade >=70)
        {
            Console.WriteLine("Congradulation you passed the class! ");
        }
        else 
        {
            Console.WriteLine("Your grade is too low, you failed. Try again.");
        }
    }
}