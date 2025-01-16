using System;
using System.IO;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        //Journal journal = new Journal();
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

            Console.WriteLine("What would you like to do? ");
            string choice= Console.ReadLine();

            if (choice == "1")
            {
                
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                //journal.AddEntry(new Entry(date, prompt, response));
            
            }
            else if (choice == "2")
            {
                //DisplayJournal();
                Console.WriteLine("Run display code");
            }
            else if (choice == "3")
            {
                //SaveJournal();
                Console.WriteLine("Run load code");
            }
            else if (choice == "4")
            {
                //LoadJournal();
                Console.WriteLine("Run save code");
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }
}