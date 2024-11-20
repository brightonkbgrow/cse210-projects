using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            return Points;  // Return points when the goal is completed
        }
        return 0;  // No points if the goal is already completed
    }

    public override string DisplayStatus()
    {
        return IsCompleted ? $"[X] {Name}: {Description} (Completed)" : $"[ ] {Name}: {Description}";
    }
}
