using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.JobTitle = "Software Engineer";
        job1.CompanyName = "Janium";
        job1.StartYear = 2023;
        job1.EndYear = 2023;

        Job job2 = new Job();
        job2.JobTitle = "Data Engineer";
        job2.CompanyName = "Crooktec";
        job2.StartYear = 2022;
        job2.EndYear = 2024;

        Resume resume = new Resume();
        resume.Name = "Cameron Crook";

        resume.Jobs = new List<Job>();
        
        resume.Jobs.Add(job1); 
        resume.Jobs.Add(job2);

        resume.Display();
    }
}