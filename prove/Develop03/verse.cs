using System;

public class Verse
{
    private string reference; 
    private string verseText;  
    private string[] words;  
    private bool[] hiddenWords;  

    public Verse(string text)
    {

        string[] parts = text.Split('|');
        reference = parts[0].Trim(); 
        verseText = parts[1].Trim(); 

        words = verseText.Split(' '); 
        hiddenWords = new bool[words.Length]; 
    }


    public string GetCurrentVerse()
    {
        string result = reference + " | "; 


        if (IsFullyHidden())
        {
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
                    result += new string('_', words[i].Length) + " ";  
                }
                else
                {
                    result += words[i] + " ";  
                }
            }
        }

        return result.Trim();
    }

    public void HideWords(int[] indices)
    {
        foreach (int index in indices)
        {
            if (index >= 0 && index < hiddenWords.Length)
            {
                hiddenWords[index] = true; 
            }
        }
    }


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


    public int WordCount()
    {
        return words.Length;
    }

    public bool IsWordHidden(int index)
    {
        if (index >= 0 && index < hiddenWords.Length)
        {
            return hiddenWords[index];
        }
        return true; 
    }
}
