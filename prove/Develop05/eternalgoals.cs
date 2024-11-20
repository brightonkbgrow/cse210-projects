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
            return Points; 
        }
        return Points; 
    }

    public override string DisplayStatus()
    {
        return $"[ ] {Name}: {Description} (Ongoing)";
    }
}
