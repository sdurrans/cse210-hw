using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string startNumber = Console.ReadLine();
        int magicNumber =int.Parse(startNumber);
        
        int userGuess = -1;
        while (magicNumber != userGuess)
        {
            Console.Write("What is your guess? ");
            string guess =Console.ReadLine();
            userGuess =int.Parse(guess);
        
            if (magicNumber > userGuess)
            {
                Console.WriteLine ("Higher");
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else 
                Console.WriteLine("You guessed it!");
        }
    }
}