using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    public void DisplayPlayerScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string goalSelection = Console.ReadLine();

        Console.WriteLine("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the description of the goal: ");
        string description = Console.ReadLine();
        Console.WriteLine("Enter the points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        if (goalSelection == "1")
        {
            goal = new SimpleGoal(name, description, points);
        }
        else if (goalSelection == "2")
        {
            goal = new EternalGoal(name, description, points);
        }
        else if (goalSelection == "3")
        {
            Console.WriteLine("Enter the required count for the goal: ");
            int requiredCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the target for the goal: ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the bonus for the goal: ");
            int bonus = int.Parse(Console.ReadLine());
            goal = new ChecklistGoal(name, description, points, target, bonus);
        }
        else
        {
            Console.WriteLine("Invalid choice. Goal not created.");
            return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully.");
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record an event.");
            return;
        }

        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.WriteLine("Enter the number of the goal: ");
        int goalIndex = int.Parse(Console.ReadLine());

        Goal selectedGoal = _goals[goalIndex - 1];
        selectedGoal.RecordEvent();
        _score += selectedGoal.GetPoints();
        Console.WriteLine("Event recorded successfully.");
    }

    public void SaveGoals()
    {
        Console.WriteLine("Enter the filename to save to: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        {
            _goals.Clear();

            Console.WriteLine("Enter the filename to load from: ");
            string file = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string goalType = parts[0].Trim();
                string name = parts[1].Trim();
                string description = parts[2].Trim();
                int points = int.Parse(parts[3].Trim());

                Goal goal = null;

                if (goalType == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4].Trim());
                    goal = new SimpleGoal(name, description, points);
                    if (isComplete)
                    {
                        goal.RecordEvent();
                    }
                }
                else if (goalType == "EternalGoal")
                {
                    goal = new EternalGoal(name, description, points);
                }
                else if (goalType == "ChecklistGoal")
                {
                    int amountCompleted = int.Parse(parts[4].Trim());
                    int target = int.Parse(parts[5].Trim());
                    int bonus = int.Parse(parts[6].Trim());
                    goal = new ChecklistGoal(name, description, points, target, bonus);
                    for (int i = 0; i < amountCompleted; i++)
                    {
                        goal.RecordEvent();
                    }
                }

                _goals.Add(goal);
            }

            Console.WriteLine($"Goals loaded from {file} successfully.");
        }
    }
}