class SimpleGoal : Goal
{
    public bool SimpleGoalIsCompleted { get; private set; }

    // Updated constructor to include isCompleted
    public SimpleGoal(string name, string description, int points, bool isCompleted = false)
        : base(name, description, points)
    {
        SimpleGoalIsCompleted = isCompleted;
    }

    public override int RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true; // Mark as completed
            return Points; // Return the points
        }
        return 0; // No points if already completed
    }

    public override string DisplayStatus()
    {
        return $"{Name,-15} {Description,-25} {Points,-10} {(IsCompleted ? "Completed" : "Not Completed")}";
    }
}
