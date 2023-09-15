using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grade Percentage: ");
        int grade_percent = int.Parse(Console.ReadLine());
        int last_digit = grade_percent % 10;

        string letter_grade = "";
        if (grade_percent >= 90)
        {
            letter_grade = "A";
        } 
        else if (grade_percent >= 80)
        {
            letter_grade = "B";
        } 
        else if (grade_percent >= 70)
        {
            letter_grade = "C";
        } 
        else if (grade_percent >= 60)
        {
            letter_grade = "D";
        } 
        else 
        {
            letter_grade = "F";
        }

        string pre_value = "";
        if (last_digit >= 7)
        {
            pre_value = "+";
        }
        else if (last_digit < 3)
        {
            pre_value = "-";
        }

        if (letter_grade == "A")
        {
            if (pre_value != "+")
            {
                letter_grade = letter_grade + pre_value;
            }
        }
        else if (letter_grade != "F")
        {
            letter_grade = letter_grade + pre_value;
        }

        Console.WriteLine($"Letter Grade: {letter_grade}");

        if (grade_percent >= 70)
        {
            Console.WriteLine("Hurray! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry. You didn't pass the class. Do better kid.");
        }
    }
}