using System;
using System.Collections.Generic;

class Program
{
    static int level = 1;
    static int xp = 0;
    static int score = 0;
    static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        goals = GoalManager.LoadGoals();

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
                    GoalManager.SaveGoals(goals);
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
        int points = GetValidatedInput("Enter points: ");

        switch (type)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                int targetCount = GetValidatedInput("Enter target count: ");
                int bonusPoints = GetValidatedInput("Enter bonus points: ");
                goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type!");
                return;
        }

        GoalManager.SaveGoals(goals);
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

            while (xp >= 1000 * level)
            {
                xp -= 1000 * level;
                level++;
                Console.WriteLine($"Congratulations! You've reached Level {level}!");
            }

            Console.WriteLine($"{pointsEarned} points earned!");
            GoalManager.SaveGoals(goals);
        }
        else
        {
            Console.WriteLine("Goal not found!");
        }
    }

    static void DisplayGoalsAndProgress()
    {
        Console.WriteLine("\nGoals:");
        Console.WriteLine($"{"Name",-15} {"Description",-25} {"Points",-10} {"Progress",-10}");
        Console.WriteLine(new string('-', 60));
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.DisplayStatus());
        }

        Console.WriteLine("\nPlayer Progress:");
        Console.WriteLine($"Level: {level}, XP: {xp}, Score: {score}");
    }

    static int GetValidatedInput(string prompt)
    {
        int result;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out result) || result < 0)
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
            Console.Write(prompt);
        }
        return result;
    }
}
