using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What did you score? ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int score))
        {
        string letter;

            if (score >= 90)
            {
                letter = "A";
            }
            else if (score >= 80)
            {
                letter = "B";
            }
            else if (score >= 70)
            {
                letter = "C";
            }
            else
            {
                letter = "F";
            }

        if (score >= 70)
        {
            Console.WriteLine($"Your grade is {letter}. You Passed!");
        }
        else if (score < 70)
        {
            Console.WriteLine($"Your grade is {letter}. You failed.");
        }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid score.");
    }


        }
    }
}