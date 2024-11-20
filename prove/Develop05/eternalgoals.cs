using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            return Points;  // Return points on completion (can reset completion if needed)
        }
        return Points;  // Keep rewarding points on every record
    }

    public override string DisplayStatus()
    {
        return $"[ ] {Name}: {Description} (Ongoing)";
    }
}
