using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num = 0;
        List<int> numbers = new List<int>();

        do
        {
            Console.WriteLine("Enter number:");
            num = int.Parse(Console.ReadLine());

            numbers.Add(num);
        } while (num != 0);

        int sum = 0;
        int largest = 0;
        foreach(int value in numbers)
        {
            sum += value;

            if (value > largest)
            {
                largest = value;
            }
        }

        int average = sum / numbers.Count;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest: {largest}");
    }
}