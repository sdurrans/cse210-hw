public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        
        Console.WriteLine($"You have recorded an event for the goal: {_shortname}");
        
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortname} - {_description} - Points: {_points} - Complete: {_isComplete}";
    }
}