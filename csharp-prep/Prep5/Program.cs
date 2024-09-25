using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your Name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Give me a Number. ");
        int number = int.Parse(Console.ReadLine());
        return number;

    }
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }        
    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, your number squared is {squared}");
    }


}