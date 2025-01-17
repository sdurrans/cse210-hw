public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        //DISPLAY ALL THE ENTRIED INTO THE _ENTRY LIST
        Console.WriteLine("\nJournal Entries:");
            foreach (var entry in _entries)
            {
                entry.Display();
                Console.WriteLine(); 
            }
    }


    public void SaveToFile(string file)
    {
        //LOOP THROUGH EACH ITEM IN _ENTRIED AND SAVE IN A FILE
        using (StreamWriter writer = new StreamWriter(file))
    {
        foreach (var entry in _entries)
        {
            writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
        }
    }
    Console.WriteLine($"Journal saved to {file} successfully.");
    }


    public void LoadFromFile(string file)
    {
    
    _entries.Clear();

    string[] lines = System.IO.File.ReadAllLines(file);

    foreach (string line in lines)
    {
        string[] parts = line.Split(",");
        
        string date = parts[0].Trim();
        string promptText = parts[1].Trim();
        string entryText = parts[2].Trim();

        _entries.Add(new Entry
        {
        
            _date = date,
            _promptText = promptText,
            _entryText = entryText
        });
        
    }

    Console.WriteLine($"Journal loaded from {file} successfully.");
    
    }
}


