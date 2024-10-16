using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();

        Console.WriteLine("Lets make a fraction");
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}
