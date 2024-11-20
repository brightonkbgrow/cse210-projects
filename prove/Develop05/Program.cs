// Program.cs
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static int level = 1;
    static int xp = 0;
    static int score = 0;
    static List<Goal> goals = new List<Goal>();
    static string filePath = "goallist.txt";

    static void Main(string[] args)
    {
        LoadGoalsFromFile();

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
                    SaveGoalsToFile();
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void CreateNewGoal()
    {
        Console.Write("Enter goal type (Simple/Eternal/Checklist): ");
        string type = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "Simple")
            goals.Add(new SimpleGoal(name, description, points));
        else if (type == "Eternal")
            goals.Add(new EternalGoal(name, description, points));
        else if (type == "Checklist")
        {
            Console.Write("Enter target count: ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
        }

        SaveGoalsToFile();  // Save goals after creation
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
                Console.WriteLine($"Level Up! You are now at Level {level}!");
            }

            Console.WriteLine($"You earned {pointsEarned} points!");
            SaveGoalsToFile();  // Save goals after recording an event
        }
        else
        {
            Console.WriteLine("Goal not found!");
        }
    }

    static void DisplayGoalsAndProgress()
    {
        Console.WriteLine("\nGoals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.DisplayStatus());
        }

        Console.WriteLine("\nPlayer Progress:");
        Console.WriteLine($"Level: {level}, XP: {xp}, Score: {score}");
    }

    static void LoadGoalsFromFile()
    {
        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length < 4) continue;

                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (type == "Simple")
                    goals.Add(new SimpleGoal(name, description, points));
                else if (type == "Eternal")
                    goals.Add(new EternalGoal(name, description, points));
                else if (type == "Checklist")
                {
                    int targetCount = int.Parse(parts[4]);
                    int bonusPoints = int.Parse(parts[5]);
                    goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                }
            }
        }
    }

    static void SaveGoalsToFile()
    {
        List<string> lines = new List<string>();
        foreach (var goal in goals)
        {
            string line = goal.GetType().Name + "," + goal.Name + "," + goal.Description + "," + goal.Points;
            if (goal is ChecklistGoal checklistGoal)
            {
                line += "," + checklistGoal.TargetCount + "," + checklistGoal.BonusPoints;
            }
            lines.Add(line);
        }
        File.WriteAllLines(filePath, lines);
    }
}
