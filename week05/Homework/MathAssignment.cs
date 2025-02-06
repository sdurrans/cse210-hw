using System;

class MathAssignment : Assignment
{
    private string _bookSection;
    private string _assignedProblems;

    public MathAssignment (string name, string topic, string bookSection, string assignedProblems)
    : base(name,topic)
    {

        _bookSection= bookSection;
        _assignedProblems= assignedProblems;
    }

    public string GetHomeworkList()
    {
        return $"Book Section {_bookSection} Problems {_assignedProblems}";
    }
}
