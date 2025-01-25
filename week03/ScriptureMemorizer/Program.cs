using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3,5,6);
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            scripture.GetDisplayText();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");

            string input = Console.ReadLine();
            if (input== "quit")
            {
                break;
            }

            if (scripture.HideRandomWords()==false)
            {
                Console.WriteLine("All words are hidden.");
                break;
            }
        }
    }
}