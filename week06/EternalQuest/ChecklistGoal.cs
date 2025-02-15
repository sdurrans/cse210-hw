public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    
    public int GetBonus()
    {
        return _bonus;
    }

    public int GetTarget()
    {
        return _target;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public new void RecordEvent()
    {        
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"You have recorded an event for the goal: {_shortname}");
        }
        else
        {
            Console.WriteLine($"You have already completed the goal: {_shortname}");
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
        }
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{_shortname} - {_description} - Points: {_points} - Complete: {_isComplete} - Target: {_target} - Amount Completed: {_amountCompleted}";
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortname},{_description},{_points},{_isComplete},{_target},{_amountCompleted},{_bonus}";
    }
}