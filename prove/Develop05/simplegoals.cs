class SimpleGoal : Goal
{
    public bool SimpleGoalIsCompleted { get; private set; }

    public SimpleGoal(string name, string description, int points, bool isCompleted = false)
        : base(name, description, points)
    {
        SimpleGoalIsCompleted = isCompleted;
    }

    public override int RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true; 
            return Points;
        }
        return 0;
    }

    public override string DisplayStatus()
    {
        return $"{Name,-15} {Description,-25} {Points,-10} {(IsCompleted ? "Completed" : "Not Completed")}";
    }
}
