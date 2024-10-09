using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<string> entries = new List<string>();

    public void AddEntry(string prompt, string response)
    {
        string date = DateTime.Now.ToShortDateString();
        string entry = $"{date} | Prompt: {prompt} | Response: {response}";
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (string entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (string entry in entries)
            {
                writer.WriteLine(entry);
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                entries.Add(line);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
