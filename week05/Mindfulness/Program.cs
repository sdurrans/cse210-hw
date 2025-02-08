using System;

class Program
{
    static void Main(string[] args)
    {
        //Activity A1 = new Activity();

        Console.WriteLine("Hello, Welcome to the Mindfulness Program!");
        Console.WriteLine("Please select of the the Following choices. ");

        while (true)
        {
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.Write("What would you like to do? ");
            string choice= Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Breathing");
            }
            else if (choice == "2")
             {
                Console.WriteLine("Reflecting");
            }
            else if (choice == "3")
             {
                Console.WriteLine("Listing");
            }
            else if (choice == "4")
            {
                Console.WriteLine("quit ");
                break;
            }
            
        }   

    }
}