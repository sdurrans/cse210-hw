using System;

class ListingActivity: Activity
{
    public ListingActivity() : 
    base ("Listening Activity","This activity will help you reflect on the good things in your life by \nhaving you list as many things as you can in a certain area.")
    {

    }

    public void Run()
    {
        
        DisplayStartingMessage();

        int duration = GetDuration();

        //Console.WriteLine($"ListingActivity {_duration} long");
    }
}