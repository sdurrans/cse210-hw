using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int grade =int.Parse(userGrade);

        if (grade >= 90)
        {
            Console.WriteLine("Your grade is and A");
        }

        else if (grade >= 80 && grade < 90)
        {
            Console.WriteLine("Your grade is a B");
        }
        else if (grade >= 70 && grade < 80)
        {
            Console.WriteLine("Your grade is a C");
        }
        else if (grade >= 60 && grade < 70)
        {
            Console.WriteLine("Your grade is a D");
        }
        else 
        {
            Console.WriteLine("Your grade is a F");
        }

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