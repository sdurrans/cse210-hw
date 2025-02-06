using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Stuart Durrant", "Programming C#");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Jessica Durrant","Law School 101", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
    }
}