using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> logs = GetLogs();

        string response = "";
        do
        {
            response = MenuSelection();

            if (response == "1") 
            {
                BreathingActivity breathingActivity = new BreathingActivity();

                breathingActivity.InitActivity();
                breathingActivity.RunActivity(breathingActivity.GetDuration());

                logs["Breathing"] += 1;

                breathingActivity.EndActivity(logs["Breathing"]);
            } else if (response == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.InitActivity();
                reflectingActivity.RunActivity(reflectingActivity.GetDuration());

                logs["Reflecting"] += 1;
                reflectingActivity.EndActivity(logs["Reflecting"]);
            } else if (response == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.InitActivity();
                listingActivity.RunActivity(listingActivity.GetDuration());

                logs["Listing"] += 1;
                listingActivity.EndActivity(logs["Listing"]);
            } else if (response == "4")
            {
                WriteLogs(logs);
            }

        } while (response != "4");

        return;
    }

    static string MenuSelection()
    {
        Console.Clear();

        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Start Breathing Activity");
        Console.WriteLine(" 2. Start Reflecting Activity");
        Console.WriteLine(" 3. Start Listening Activity");
        Console.WriteLine(" 4. Quit");

        Console.Write("Select a choice from the menu: ");
        string response = Console.ReadLine();

        return response;
    }

    static Dictionary<string, int> GetLogs()
    {
        Dictionary<string, int> logs = new Dictionary<string, int>();

        try
        {
            using (StreamReader reader = new StreamReader("logs.csv"))
            {
                string content = reader.ReadToEnd();

                string[] fileEntries = content.Split('\n');

                foreach(string fileEntry in fileEntries)
                {
                    if (fileEntry != "")
                    {
                        string[] entryItems = fileEntry.Split(',');

                        logs.Add(entryItems[0], int.Parse(entryItems[1]));
                    }
                    
                }
            }

            return logs;
        }
        catch (Exception)
        {
            logs.Add("Breathing", 0);
            logs.Add("Reflecting", 0);
            logs.Add("Listing", 0);

            return logs;
        }
    }

    static void WriteLogs(Dictionary<string, int> logs)
    {
        using (StreamWriter writer = new StreamWriter("logs.csv"))
        {
            if (logs.Count > 0)
            {
                foreach(var log in logs)
                {
                    writer.WriteLine($"{log.Key},{log.Value}");
                }
            }

            return;
        }
    }
}