using System;

class Program
{
    static void Main(string[] args)
    {
        ListVerse listVerse = new ListVerse();
        string input = "";

        // Get a random verse from the ListVerse class
        string randomVerseText = listVerse.GetRandomVerse();

        // Create instances of Verse and Word to handle the verse and word hiding
        Verse verse = new Verse(randomVerseText);
        Word word = new Word();

        Console.WriteLine("Press Enter to hide 3 words, or type 'exit' to quit.");
        Console.WriteLine(verse.GetCurrentVerse());  // Display the initial verse

        while (input != "exit")
        {
            // Check if all words are hidden before prompting for input
            if (verse.IsFullyHidden())
            {
                Console.WriteLine("All words are hidden.");
                break;  // Exit the loop if all words are hidden
            }

            input = Console.ReadLine();  // Wait for user input

            if (input == "exit")
                break;

            // Get 3 random words to hide, ensuring they are not already hidden
            int[] indicesToHide = word.GetRandomIndices(verse.WordCount(), verse);

            // Hide those words in the verse
            verse.HideWords(indicesToHide);

            // Display the updated verse
            Console.WriteLine(verse.GetCurrentVerse());

            // Check again if all words are now hidden after hiding new words
            if (verse.IsFullyHidden())
            {
                Console.WriteLine("All words are hidden.");
                break;  // Exit the loop if all words are hidden
            }
        }

        Console.WriteLine("Program exited.");  // Final message
    }
}
