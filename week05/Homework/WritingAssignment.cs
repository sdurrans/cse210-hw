using System;

class WritingAssignment : Assignment

{
    public string _title;

    public WritingAssignment (string name, string topic, string title)
    : base(name,topic)
    {
        _title = title
    }

    public string GetWritingInformation()
    {
        return "Writing Information";
    }
}
