using System;

class Program
{
    
    static void Main(string[] args)
    {
        int navinput = 0;
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
                string prompt = promptGen.GetRandomPrompt();
                Journal.WriteEntry;
            else if (navinput == 2)
                Journal.SaveEntry; 
            
            else if (navinput == 3)
                Journal.LoadEntry;
            else if (navinput == 4)
                Journal.Display;

            else if (navinput != 5)
                Console.WriteLine("Your entry is invalid");

        }
    }
}
