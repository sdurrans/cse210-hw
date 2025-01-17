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
    }

    public void LoadFromFile(string file)
    {
        //lOOP THROUGH EACH LINE OF THE FILE AND CREATE ENTRY OBJECTS TO PUT IN THE LIST 
    }
}


