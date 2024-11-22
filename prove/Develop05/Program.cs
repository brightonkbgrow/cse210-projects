using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static int level = 1;
    static int xp = 0;
    static int score = 0;
    static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        LoadFromFile();

        while (true)
        {
            Console.WriteLine("\nEternal Quest");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals and Progress");
            Console.WriteLine("4. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;

                case "2":
                    RecordGoalEvent();
                    break;

                case "3":
                    DisplayGoalsAndProgress();
                    break;

                case "4":
                    SaveToFile();
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("What Kind Of Goal Do You Have?");
        Console.WriteLine("1: Simple");
        Console.WriteLine("2: Eternal");
        Console.WriteLine("3: Checklist");
        string type = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
            goals.Add(new SimpleGoal(name, description, points));
        else if (type == "2")
            goals.Add(new EternalGoal(name, description, points));
        else if (type == "3")
        {
            Console.Write("Enter target count: ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
        }

        SaveToFile();  
    }

    static void RecordGoalEvent()
    {
        Console.Write("Enter the goal name to record: ");
        string goalName = Console.ReadLine();

        Goal goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            int pointsEarned = goal.RecordEvent();
            score += pointsEarned;
            xp += pointsEarned;

            if (xp >= 1000 * level)
            {
                level++;
                xp = 0;
                Console.WriteLine($"You've Reached {level}!");
            }

            Console.WriteLine($"{pointsEarned} points earned!");
            SaveToFile(); 
        }
        else
        {
            Console.WriteLine("Goal not found!");
        }
    }

    static void DisplayGoalsAndProgress()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("\nNo goals to display.");
            return;
        }

        Console.WriteLine("\nGoals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.DisplayStatus());
        }

        Console.WriteLine("\nPlayer Progress:");
        Console.WriteLine($"Level: {level}, XP: {xp}, Score: {score}");
    }

    static void LoadFromFile()
    {
        if (File.Exists("goallist.txt"))
        {
            Console.WriteLine("Loading goals from file...");
            try
            {
                var lines = File.ReadAllLines("goallist.txt");
                bool progressLoaded = false;

                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 0) continue;

                    if (parts[0] == "Progress")
                    {
                        level = int.Parse(parts[1]);
                        xp = int.Parse(parts[2]);
                        score = int.Parse(parts[3]);
                        progressLoaded = true;
                    }
                    else if (parts.Length >= 4)
                    {
                        string type = parts[0];
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);

                        if (type == "Simple")
                        {
                            goals.Add(new SimpleGoal(name, description, points));
                        }
                        else if (type == "Eternal")
                        {
                            goals.Add(new EternalGoal(name, description, points));
                        }
                        else if (type == "Checklist")
                        {
                            if (parts.Length < 7) continue;
                            int targetCount = int.Parse(parts[4]);
                            int bonusPoints = int.Parse(parts[5]);
                            int currentCount = int.Parse(parts[6]);
                            goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints, currentCount));
                        }
                    }
                }

                if (!progressLoaded)
                {
                    Console.WriteLine("Progress data was not found. Starting fresh with default values.");
                }

                Console.WriteLine("Goals successfully loaded!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("No existing goals found. Starting fresh.");
        }
    }

    static void SaveToFile()
    {
        try
        {
            List<string> lines = new List<string>();

            lines.Add($"Progress,{level},{xp},{score}");

            foreach (var goal in goals)
            {
                string line = goal.GetType().Name + "," + goal.Name + "," + goal.Description + "," + goal.Points;
                if (goal is ChecklistGoal checklistGoal)
                {
                    line += "," + checklistGoal.TargetCount + "," + checklistGoal.BonusPoints + "," + checklistGoal.CurrentCount;
                }
                lines.Add(line);
            }

            File.AppendAllLines("goallist.txt", lines);
            Console.WriteLine("Progress saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving to file: {ex.Message}");
        }
    }
}
