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
        Console.WriteLine($"\nWelcome to the {_name}");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
    
        Console.Write("How long do you want to do the activity? ");
        string sduration = Console.ReadLine();
        _duration = int.Parse(sduration);

        Console.WriteLine($"\n{_name} will be {_duration} seconds long");
    }   

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done!!");
        ShowSpinner(5);
        Console.WriteLine("");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}");
        ShowSpinner(5);
        Console.WriteLine("");
            
    }   

    public int GetDuration()
    {
        return _duration;
    }
    public void ShowSpinner(int _duration)
    {
        List<string> spinner = new List<string>() ;
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

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
        Console.WriteLine("done");
    }
}