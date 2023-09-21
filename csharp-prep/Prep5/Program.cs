using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number:");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquareNumber(int number)
        {
            int sqrt = number * number;

            return sqrt;
        }

        static void DisplayResult(string name, int sqrt)
        {
            Console.WriteLine($"{name}, the square of your number is {sqrt}");
        }

        DisplayMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int sqrt = SquareNumber(number);

        DisplayResult(name, sqrt);
    }
}