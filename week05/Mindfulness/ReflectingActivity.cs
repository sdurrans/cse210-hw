using System;

class ReflectingActivity : Activity
{
    
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _question = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : 
    base("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Run()
    {
        Console.Clear(); 
        DisplayStartingMessage();
        int duration = GetDuration();
        
        Console.Clear(); 
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("When you are ready, press enter");
        Console.ReadLine();
               
        
        Console.WriteLine("Now ponder on each of the following questions in ralation to this experience.");
        Console.WriteLine("You may begin in: ");   
        ShowCountDown(7);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {            
            Console.WriteLine($">{GetRandomQuestion()}");
            ShowSpinner(10); 
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
    private string GetRandomQuestion()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(_question.Count); 
        string question = _question[randomIndex]; 
        

        return question;
    
    }
    
}