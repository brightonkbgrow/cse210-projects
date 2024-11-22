using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private const string FileName = "goallist.txt";


    public static List<Goal> LoadGoals()
    {
        var goals = new List<Goal>();
        if (!File.Exists(FileName)) return goals;

        foreach (var line in File.ReadAllLines(FileName))
        {
            string[] parts = line.Split(',');
            if (parts.Length < 4) continue;

            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "Simple")
            {
                bool isCompleted = parts.Length > 4 && bool.Parse(parts[4]);
                goals.Add(new SimpleGoal(name, description, points, isCompleted));
            }
            else if (type == "Eternal")
            {
                goals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "Checklist" && parts.Length >= 7)
            {
                int targetCount = int.Parse(parts[4]);
                int bonusPoints = int.Parse(parts[5]);
                int currentCount = int.Parse(parts[6]);
                goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints, currentCount));
            }
        }

        return goals;
    }


    public static void SaveGoals(List<Goal> goals)
    {
        var lines = new List<string>();
        foreach (var goal in goals)
        {
            string line = goal.GetType().Name + "," + goal.Name + "," + goal.Description + "," + goal.Points;
            if (goal is SimpleGoal simpleGoal)
            {
                line += "," + simpleGoal.IsCompleted;
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                line += "," + checklistGoal.TargetCount + "," + checklistGoal.BonusPoints + "," + checklistGoal.CurrentCount;
            }
            lines.Add(line);
        }

        File.WriteAllLines(FileName, lines);
    }
}
