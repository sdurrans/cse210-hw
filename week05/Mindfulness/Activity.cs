using System;

class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
        
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_name}");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
    
        Console.Write("How long do you want to do the activity? ");
        string sduration = Console.ReadLine();
        _duration = int.Parse(sduration);
        Console.Clear();
        Console.WriteLine($"\n{_name} will be {_duration} seconds long");
        Console.WriteLine("Hit enter to begin");
        Console.ReadLine();
    }   

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done!!");        
        Console.WriteLine("");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}");       
        Console.WriteLine("");
        Console.WriteLine("Now get ready for the next activity? Hit enter to continue");
        Console.ReadLine();
        Console.Clear();
                    
    }   

    public int GetDuration()
    {
        return _duration;
    }
    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>() ;
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
                
    }

    public void ShowCountDown(int seconds)

    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
}