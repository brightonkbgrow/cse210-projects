using System;

public class Program
{
    
    static void Main(string[] args)
    {
        int navinput = 0;
        Journal journal = new Journal();
        PromptGen promptGen = new PromptGen();
        while (navinput != 5) 
        {

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Save");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Read");
            Console.WriteLine("5. Exit");

            navinput = int.Parse(Console.ReadLine()); 


            if (navinput == 1)
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                journal.AddEntry(prompt, response);
            }

            else if (navinput == 2)
            {
                journal.SaveEntry("savedJournal.txt");
            }

            
            else if (navinput == 3)
                journal.LoadEntry("savedJournal.txt");
            else if (navinput == 4)
                journal.DisplayJournal();

            else if (navinput != 5)
                Console.WriteLine("Your entry is invalid");

        }
    }
}
