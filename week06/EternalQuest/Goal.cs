using System;

class Goal
{
    private string _shortname;
    private string _description;
    private int _points;
    private bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _shortname = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public void RecordEvent()
    {
        if (_isComplete != true)
        {
            Console.WriteLine($"You have completed the goal: {_shortname}");
            _isComplete = true;
        }
        else
        {
            Console.WriteLine($"You have already completed the goal: {_shortname}");
        }
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public string GetDetailsString()
    {
        return $"{_shortname} - {_description} - Points: {_points} - Complete: {_isComplete}";
    }   
    
}