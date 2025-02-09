using System;

class Program
{
    static void Main(string[] args)
    {
        //Activity A1 = new Activity();

        Console.WriteLine("\nHello, Welcome to the Mindfulness Program!");
        

        while (true)
        {
            Console.WriteLine("\nPlease select of the the Following choices. \n");

            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.Write("What would you like to do? ");
            string choice= Console.ReadLine();

            if (choice == "1")
            {
                
                BreathingActivity bactivity = new BreathingActivity();

                bactivity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity ractivity = new ReflectingActivity();

                ractivity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity lactivity = new ListingActivity();

                lactivity.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Quit ");
                break;
            }
            
        }   

    }
}