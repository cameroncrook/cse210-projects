using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        fraction1.SetTop(5);
        float resultDec = fraction1.GetDecimal();

        Fraction fraction2 = new Fraction();
        fraction2.SetTop(3);
        fraction2.SetBottom(4);
        float frac2_result = fraction2.GetDecimal();

        Fraction fraction3 = new Fraction();
        fraction3.SetTop(9);
        fraction3.SetBottom(16);
        string fraction = fraction3.GetFraction();

        Console.WriteLine(resultDec);
        Console.WriteLine(frac2_result);
        Console.WriteLine(fraction);
    }
}