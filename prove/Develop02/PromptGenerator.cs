public class PromptGenerator
{
    // Properties
    public List<string> Prompts { get; set; }

    // Methods
    public void Init()
    {
        this.Prompts = new List<string>();
        this.Prompts.Add("Who was the most interesting person I interacted with today?");
        this.Prompts.Add("What was the best part of my day?");
        this.Prompts.Add("How did I see the hand of the Lord in my life today?");
        this.Prompts.Add("What was the strongest emotion I felt today?");
        this.Prompts.Add("If I had one thing I could do over today, what would it be?");
        this.Prompts.Add("What was something funny that happened?");
        this.Prompts.Add("What was the strangest thing that occured today?");
        this.Prompts.Add("What did you eat today?");
        this.Prompts.Add("Name a song that you listened to today?");

        return;
    }
    public void DisplayPrompts()
    {
        Console.WriteLine("Avaiable Prompts:");
        foreach(string prompt in this.Prompts)
        {
            Console.WriteLine(prompt);
        }

        return;
    }
    public string GenerateRandomPrompt()
    {
        Random random = new Random();

        int randomIndex = random.Next(0, this.Prompts.Count);

        string prompt = this.Prompts[randomIndex];

        return prompt;
    }
}