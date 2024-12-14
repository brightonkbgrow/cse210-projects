using System;

public class Running : Activity
{
    private double _distance;
    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }
    public override double GetDistance() => _distance;
    public override double GetSpeed() => GetDistance() / (Minutes / 60.0);
    public override double GetPace() => Minutes / GetDistance();
}