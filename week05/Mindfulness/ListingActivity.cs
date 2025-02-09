using System;

class ListingActivity: Activity
{

    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    
    public ListingActivity() : 
    base ("Listening Activity","This activity will help you reflect on the good things in your life by \nhaving you list as many things as you can in a certain area.")
    {

    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        int duration = GetDuration();
        Console.Clear();

        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("When you are ready, press enter");
        Console.ReadLine();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {            
            Console.Write("> ");
            string response = Console.ReadLine();
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(_prompts.Count); 
        string prompt = _prompts[randomIndex]; 
    
        return prompt;
        
    }
}