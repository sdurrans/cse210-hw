using System;

public class Goal
{
    protected string _shortname;
    protected string _description;
    protected int _points;
    protected bool _isComplete;


    public Goal(string name, string description, int points)
    {
        _shortname = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }
    public virtual string GetShortName()
    {
        return _shortname;
    }
    public virtual int GetPoints()
    {
        return _points;
    }


    public virtual void RecordEvent()
    {
        if (_isComplete != true)
        {
            Console.WriteLine($"You have completed the goal:  {_shortname}");
            _isComplete = true;
        }
        else
        {
            Console.WriteLine($"You have already completed the goal:  {_shortname}");
        }
    }

    public virtual bool IsComplete()
    {
        return _isComplete;
    }

    public virtual string GetDetailsString()
    {
        return $" {_shortname} - {_description} - Points: {_points} - Complete: {_isComplete}";
    }

    public virtual string GetStringRepresentation()
    {
        return $" {_shortname},{_description},{_points},{_isComplete}";
    }

}