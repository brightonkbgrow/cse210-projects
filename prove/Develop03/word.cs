using System;

public class Word
{
    private Random rand = new Random();

    // Randomly selects word indices to hide that are not already hidden
    public int[] GetRandomIndices(int wordCount, Verse verse)
    {
        // Get the indices of visible words
        int[] visibleIndices = new int[wordCount];
        int visibleCount = 0;

        for (int i = 0; i < wordCount; i++)
        {
            if (!verse.IsWordHidden(i))
            {
                visibleIndices[visibleCount] = i;  // Store index of visible word
                visibleCount++;
            }
        }

        // If there are no visible words, return an empty array
        if (visibleCount == 0)
        {
            return new int[0];
        }

        // Determine how many words to hide: the minimum of 3 or the remaining visible words
        int wordsToHide = Math.Min(3, visibleCount);
        int[] indices = new int[wordsToHide];

        // If there are not enough words to hide, hide all remaining visible words
        if (visibleCount < 3)
        {
            for (int i = 0; i < visibleCount; i++)
            {
                indices[i] = visibleIndices[i];  // Store all visible word indices
            }
            return indices;  // Return all remaining visible words to hide
        }

        // Randomly select up to 'wordsToHide' indices
        for (int selected = 0; selected < wordsToHide; selected++)
        {
            int randomIndex = rand.Next(visibleCount);
            indices[selected] = visibleIndices[randomIndex];  // Store randomly selected index
            // Remove this index from the visible list to avoid duplicates
            visibleIndices[randomIndex] = visibleIndices[visibleCount - 1];
            visibleCount--;  // Decrease visible count
        }

        return indices;
    }
}
