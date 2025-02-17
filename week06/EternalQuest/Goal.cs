using System;

public class Goal
{
    protected string _shortname;
    protected string _description;
    protected int _points;


    public Goal(string name, string description, int points)
    {
        _shortname = name;
        _description = description;
        _points = points;
        
    }

    public virtual void RecordEvent()
    {
        
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortname} - {_description} - Points: {_points}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"[ ] {_shortname},{_description},{_points}";
    }

    public int GetPoints()
    {
        return _points;
    }
}