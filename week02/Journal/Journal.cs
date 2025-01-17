public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        // PUT NEWENTRY  INTO _ENTRIES
    }

    public void DisplayAll()
    {
        //DISPLAY ALL THE ENTRIED INTO THE _ENTRY LIST
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


