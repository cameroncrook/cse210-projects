using System.ComponentModel;

public class Activity
{
    private string _activityName;
    private string _welcomeMessage;
    private int _duration;

    public Activity(string activity, string welcomeMessage)
    {
        _activityName = activity;
        _welcomeMessage = welcomeMessage;
        
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int duration = int.Parse(Console.ReadLine());

        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    //utility
    public string GetRandomValue(List<string> items) {
        Random random = new Random();
        int randomIndex = random.Next(0, items.Count);
        string randomValue = items[randomIndex];

        return randomValue;
    }

    public void Countdown(int duration) {
        for (int i=duration; i>=0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void Spinner(int duration=5)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b"); // Erase the + character

            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }


    // start stop
    public void InitActivity()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity\n");
        Console.WriteLine(_welcomeMessage);

        Console.WriteLine("\nGet Ready...");
        Spinner(3);
    }

    public void EndActivity(int counter)
    {
        Console.WriteLine("\nWell Done!");
        Spinner();
        Console.WriteLine($"\nYou have completed another {_duration} seconds of {_activityName} Activity\n");
        Console.WriteLine($"You have completed this activity {counter} times!");
        Spinner();

        return;
    }
}