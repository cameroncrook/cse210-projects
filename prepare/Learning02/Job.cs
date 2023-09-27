public class Job
{
    // Properties
    public string CompanyName = "";
    public string JobTitle = "";
    public int StartYear = 0;
    public int EndYear = 0;

    // Constructor
    public Job()
    {
    }

    // Methods
    public void Display()
    {
        Console.WriteLine($"{this.JobTitle} ({this.CompanyName}) {this.StartYear}-{this.EndYear}");
    }
}