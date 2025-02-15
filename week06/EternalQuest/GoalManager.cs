using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score = 0;

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
        Console.WriteLine("Enter the name of the goal: ");
        string name = Console.ReadLine();
        foreach (Goal goal in _goals)
        {
            if (goal.GetShortName() == name)
            {
                goal.RecordEvent();
                _score += goal.GetPoints();
            }
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("Enter the filename to save to: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear();

        Console.WriteLine("Enter the filename to load from: ");
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string name = parts[0].Trim();
            string description = parts[1].Trim();
            int points = int.Parse(parts[2].Trim());
            bool isComplete = bool.Parse(parts[3].Trim());

            Goal goal = new Goal(name, description, points);
            if (isComplete)
            {
                goal.RecordEvent();
            }
            _goals.Add(goal);
        }

        Console.WriteLine($"Goals loaded from {file} successfully.");
    }
}

