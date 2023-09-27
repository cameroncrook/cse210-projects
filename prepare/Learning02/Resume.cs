public class Resume
{
    // Properties
    public string Name { get; set; }
    public List<Job> Jobs { get; set; }

    // Constructor
    public Resume()
    {
    }

    // Methods
    public void Display()
    {
        Console.WriteLine(this.Name);
        foreach (Job job in this.Jobs)
        {
            job.Display();
        }
    }

}

// code . - opens up vs code in current directory
// dotnet list - lists types of projects you can create
// dotnet new console - creates project of type console
