using System;

class Program
{
    static void Main(string[] args)
    {
        ListVerse listVerse = new ListVerse();
        string input = "";


        string randomVerseText = listVerse.GetRandomVerse();


        Verse verse = new Verse(randomVerseText);
        Word word = new Word();

        Console.WriteLine("Press Enter to hide 3 words, or type 'exit' to quit.");
        Console.WriteLine(verse.GetCurrentVerse()); 

        while (input != "exit")
        {

            if (verse.IsFullyHidden())
            {
                Console.WriteLine("All words are hidden.");
                break;  
            }

            input = Console.ReadLine(); 

            if (input == "exit")
                break;


            int[] indicesToHide = word.GetRandomIndices(verse.WordCount(), verse);


            verse.HideWords(indicesToHide);


            Console.WriteLine(verse.GetCurrentVerse());


            if (verse.IsFullyHidden())
            {
                Console.WriteLine("All words are hidden.");
                break;  
            }
        }

        Console.WriteLine("Program exited."); 
    }
}
