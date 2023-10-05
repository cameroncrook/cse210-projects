using System.ComponentModel;

public class Journal
{
    // Properties
    public List<Entry> Entries { get; set; }

    // Methods
    public void DisplayJournal()
    {
        if (this.Entries.Count > 0)
        {
            foreach(Entry entry in Entries)
            {
                Console.WriteLine(entry.Date);
                Console.WriteLine(entry.Prompt);
                Console.WriteLine(entry.Response);
                Console.WriteLine("");
            }
        }
        else
        {
            Console.WriteLine("No entries yet.");
        }
        
    }
    public void SaveToFile()
    {
        string file = "journal.csv";

        using (StreamWriter writer = new StreamWriter(file))
        {
            if (this.Entries.Count > 0)
            {
                foreach(Entry entry in this.Entries)
                {
                    writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
                }

                Console.WriteLine("Journal Saved");
            }
            else
            {
                Console.WriteLine("No journal entries");
            }

            return;
        }
    }
    public void LoadFromFile()
    {
        string file = "journal.csv";

        try
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string content = reader.ReadToEnd();

                string[] fileEntries = content.Split('\n');

                foreach(string fileEntry in fileEntries)
                {
                    if (fileEntry != "")
                    {
                        string[] entryItems = fileEntry.Split(',');

                        Entry entry = new Entry();

                        entry.Date = entryItems[0];
                        entry.Prompt = entryItems[1];
                        entry.Response = entryItems[2];

                        this.Entries.Add(entry);
                    }
                    
                }
            }

            Console.WriteLine("Load Complete");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error occured:");
            Console.WriteLine(e);
        }
    }
}