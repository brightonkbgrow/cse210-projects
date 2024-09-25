using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        Console.Write("Guess my magic number! It's between 1 and 100. ");
        int guess;

        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out guess) && guess >= 1 && guess <= 100)
            {
                if (guess == number)
                {
                    Console.WriteLine("You Guessed Right.");
                    break;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too High.");
                }
                else
                {
                    Console.WriteLine("Too Low.");
                }
            }
            else
            {
                Console.WriteLine("That isnt even a valid option. only numbers between 1 and 100.");
            }

            Console.Write("Guess Again: ");
        }
    }
}
