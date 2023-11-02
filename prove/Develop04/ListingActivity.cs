public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void RunActivity(int duration)
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");

        // Get Random Prompt
        string prompt = base.GetRandomValue(_prompts);
        Console.WriteLine($"--- {prompt} ---");

        Console.Write("\nYou may begin in...");
        base.Countdown(5);

        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int counter = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();

            counter++;
        }

        Console.WriteLine($"You have listed {counter} items!");

        return;
    }
}