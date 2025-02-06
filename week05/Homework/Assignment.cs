using System;

class Assignment
{
    public string _studentName;
    public string _topic;

    public Assignment (string name, string topic)
    {
        _name = name;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $ "{_name} - {_topic}";
    }

}