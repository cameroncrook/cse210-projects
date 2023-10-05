public class Entry
{
    // Properties
    public string Date = "";
    public string Prompt = "";
    public string Response = "";

    // Methods
    public void GenerateEntry(PromptGenerator promptGen)
    {
        Console.WriteLine("Date:");
        string date = Console.ReadLine();
        this.Date = date;

        string prompt = promptGen.GenerateRandomPrompt();
        this.Prompt = prompt;

        Console.WriteLine(this.Prompt);
        string response = Console.ReadLine();
        this.Response = response;
    }
    public void Troubleshooting(PromptGenerator promptGen)
    {
        promptGen.DisplayPrompts();
        string prompt = promptGen.GenerateRandomPrompt();
        Console.WriteLine("");
        Console.WriteLine(prompt);
        Console.WriteLine("");
    }
}