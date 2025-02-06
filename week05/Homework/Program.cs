using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Stuart Durrant", "Programming C#");
        Console.WriteLine(assignment1.GetSummary());
    }
}