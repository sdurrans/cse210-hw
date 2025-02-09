using System;

class BreathingActivity: Activity
{
    public BreathingActivity() : 
    base ("Breathing Activity","This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {
        
        DisplayStartingMessage();

        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in...");
            ShowSpinner(3);
            Console.WriteLine("Now breath out...");
            ShowSpinner(3);
        }
        
        DisplayEndingMessage();
    }
}