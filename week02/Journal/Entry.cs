public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;


    public void Display()
    {
        Console.WriteLine($"{_date} Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");

    }
}