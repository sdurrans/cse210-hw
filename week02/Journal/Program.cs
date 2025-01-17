using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program! .");
        Console.WriteLine("Please select of the the Following choices. ");

        while (true)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string choice= Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                string response = Console.ReadLine();
                journal.AddEntry(new Entry
                {
                    _date = DateTime.Now.ToString("yyyy-MM-dd"),
                    _promptText = prompt,
                    _entryText = response
                });
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
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
