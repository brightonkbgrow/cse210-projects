using System;

public class Word
{
    private Random rand = new Random();


    public int[] GetRandomIndices(int wordCount, Verse verse)
    {
        int[] visibleIndices = new int[wordCount];
        int visibleCount = 0;

        for (int i = 0; i < wordCount; i++)
        {
            if (!verse.IsWordHidden(i))
            {
                visibleIndices[visibleCount] = i;  
                visibleCount++;
            }
        }


        if (visibleCount == 0)
        {
            return new int[0];
        }


        int wordsToHide = Math.Min(3, visibleCount);
        int[] indices = new int[wordsToHide];


        if (visibleCount < 3)
        {
            for (int i = 0; i < visibleCount; i++)
            {
                indices[i] = visibleIndices[i]; 
            }
            return indices;  
        }


        for (int selected = 0; selected < wordsToHide; selected++)
        {
            int randomIndex = rand.Next(visibleCount);
            indices[selected] = visibleIndices[randomIndex]; 

            visibleIndices[randomIndex] = visibleIndices[visibleCount - 1];
            visibleCount--;  
        }

        return indices;
    }
}
