using System;

public class Verse
{
    private string reference;  // Stores the scripture reference (part before '|')
    private string verseText;  // Stores the verse text (part after '|')
    private string[] words;    // Array of words in the verse text
    private bool[] hiddenWords;  // Boolean array to track which words are hidden

    public Verse(string text)
    {
        // Split the input string into reference and verse parts
        string[] parts = text.Split('|');
        reference = parts[0].Trim();  // The part before '|' is the reference
        verseText = parts[1].Trim();  // The part after '|' is the verse text

        words = verseText.Split(' ');  // Split the verse text into individual words
        hiddenWords = new bool[words.Length];  // Initialize hidden words array
    }

    // Returns the current state of the verse with hidden words replaced by underscores
    public string GetCurrentVerse()
    {
        string result = reference + " | ";  // Always show the reference

        // Check if all words are hidden
        if (IsFullyHidden())
        {
            // Replace all words with underscores matching their lengths
            foreach (var word in words)
            {
                result += new string('_', word.Length) + " ";
            }
        }
        else
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (hiddenWords[i])
                {
                    result += new string('_', words[i].Length) + " ";  // Replace with underscores matching the word length
                }
                else
                {
                    result += words[i] + " ";  // Display the actual word
                }
            }
        }

        return result.Trim();
    }

    // Method to hide words based on random indices passed from Word class
    public void HideWords(int[] indices)
    {
        foreach (int index in indices)
        {
            if (index >= 0 && index < hiddenWords.Length)
            {
                hiddenWords[index] = true;  // Mark the word as hidden
            }
        }
    }

    // Check if all words are hidden
    public bool IsFullyHidden()
    {
        foreach (bool hidden in hiddenWords)
        {
            if (!hidden)
            {
                return false;
            }
        }
        return true;
    }

    // Method to return how many words there are
    public int WordCount()
    {
        return words.Length;
    }

    // Method to check if a word is already hidden
    public bool IsWordHidden(int index)
    {
        if (index >= 0 && index < hiddenWords.Length)
        {
            return hiddenWords[index];
        }
        return true;  // If index is out of bounds, return true (as if hidden)
    }
}
