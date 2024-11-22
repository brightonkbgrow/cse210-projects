class ChecklistGoal : Goal
{
    public int TargetCount { get; }
    public int BonusPoints { get; }
    public int CurrentCount { get; private set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int currentCount = 0)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = currentCount;
    }

    public override int RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++; // Increment progress
            if (CurrentCount == TargetCount)
                return Points + BonusPoints; // Full bonus when complete
            return Points; // Normal points otherwise
        }
        return 0; // No points if already completed
    }

    public override string DisplayStatus()
    {
        return $"{Name,-15} {Description,-25} {Points,-10} {CurrentCount}/{TargetCount}";
    }
}
