using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGen = new PromptGenerator();
        Journal journal = new Journal();
        journal.Entries = new List<Entry>();

        promptGen.Init();

        string response = "";

        do
        {
            Console.WriteLine("");
            Console.WriteLine("Pick an option:");
            Console.WriteLine("Write Entry [E]");
            Console.WriteLine("Display Journal [D]");
            Console.WriteLine("Save to File [S]");
            Console.WriteLine("Load from File [L]");
            Console.WriteLine("Quit [Q]");
            Console.WriteLine("");

            response = Console.ReadLine();
            response = response.ToLower();
            Console.WriteLine("");

            if (response == "e") {
                Entry entry = new Entry();
                entry.GenerateEntry(promptGen);

                journal.Entries.Add(entry);

                continue;
            }
            else if (response == "d")
            {
                journal.DisplayJournal();
            }
            else if (response == "s")
            {
                journal.SaveToFile();
            }
            else if (response == "l")
            {
                journal.LoadFromFile();
            }
            else
            {
                continue;
            }
        }
        while (response != "q");
    }
}