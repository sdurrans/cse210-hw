using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program! .");
        Console.WriteLine("Please select of the the Following choices. ");

        while (true)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do? ");
            string choice= Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("write ");
            }
            else if (choice == "2")
            {
                Console.WriteLine("display ");
            }
            else if (choice == "3")
            {
               Console.WriteLine("load");
            }
            else if (choice == "4")
            {
                Console.WriteLine("save ");
            }
            else if (choice == "5")
            {
                Console.WriteLine("quit ");
                break;
            }
        }
    }
}
