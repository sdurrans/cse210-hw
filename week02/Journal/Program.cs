using System;
using System.IO;

// to exceed requirements i thought it would be nice to cycle through all prompts before one repeats. so i added code to do that in the PromptGernerator and Programs code. I comment out the core requiremetn code.  



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
                //string prompt = promptGenerator.GetRandomPrompt();
                //string response = Console.ReadLine();
                //journal.AddEntry(new Entry
                //{
                    //_date = DateTime.Now.ToString("yyyy-MM-dd"),
                    //_promptText = prompt,
                    //_entryText = response
                //});

                //stretch requirement cycleing through all propmts until they are all used.
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry
                {
                    _date = DateTime.Now.ToString("yyyy-MM-dd"),
                    _promptText = prompt,
                    _entryText = response
                };

            journal.AddEntry(newEntry);

            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the file name to load from: ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (choice == "4")
            {
                Console.Write("Enter the file name to save to: ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (choice == "5")
            {
                Console.WriteLine("quit ");
                break;
            }
        }
    }
}
