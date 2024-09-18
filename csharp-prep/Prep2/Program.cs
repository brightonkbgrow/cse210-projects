using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What did you score? ");
        string input = Console.ReadLine();
        int score = int.Parse(input);
        string letter;
                if (score >= 90)
        {
            letter = ("A");
        }
        else if (score >= 80)
        {
            letter = ("B");
        }
        else if (score >= 70)
        {
            letter = ("C");
        }
        else if (score < 70)
        {
            letter = ("F");
        }
        if (score >= 90)
        {
            Console.WriteLine($"Your grade is {letter}. You Passed!");
        }
        else if (score >= 80)
        {
            Console.WriteLine($"Your grade is {letter}. You Passed!");
        }
        else if (score >= 70)
        {
            Console.WriteLine($"Your grade is {letter}. You Passed!");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}. You failed.");
        }

    }
}