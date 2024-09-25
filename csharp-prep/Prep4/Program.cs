using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {   
        List<double> x = new();
        double input = -1;
        Console.WriteLine("Enter numbers and press enter. then enter 0 to stop.");
        while (input != 0)
        {
            Console.Write("Enter Number: ");
            
            string input_string = Console.ReadLine();
            input = double.Parse(input_string);
            if (input != 0)
            {
                x.Add(input);
            }
        }
        double sum = Queryable.Sum(x.AsQueryable());
        Console.WriteLine($"The Sum is {sum}");

        double avg = Queryable.Average(x.AsQueryable());
        Console.WriteLine($"The Average is {avg}");

        double max = Queryable.Max(x.AsQueryable());
        Console.WriteLine($"The Largest number is {max}");
    }
}