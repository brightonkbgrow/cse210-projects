using System;

public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                return Points + BonusPoints;  // Add bonus points on reaching the target
            }
            return Points;  // Regular points for each event
        }
        return 0;  // No points if the target count is reached
    }

    public override string DisplayStatus()
    {
        return CurrentCount < TargetCount
            ? $"[ ] {Name}: {Description} (Completed {CurrentCount}/{TargetCount} times)"
            : $"[X] {Name}: {Description} (Completed)";
    }
}
