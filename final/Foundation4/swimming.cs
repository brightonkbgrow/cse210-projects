using System;

public class Swimming : Activity
{
    private int _laps;
    private const double LapLengthKilometers = 50.0 / 1000.0;
    private const double LapLengthMiles = LapLengthKilometers * 0.62;
    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance() => _laps * LapLengthMiles;
    public double GetDistanceKilometers() => _laps * LapLengthKilometers;
    public override double GetSpeed() => GetDistance() / (Minutes / 60.0);
    public double GetSpeedKilometersPerHour() => GetDistanceKilometers() / (Minutes / 60.0);
    public override double GetPace() => Minutes / GetDistance();
    public double GetPaceKilometers() => Minutes / GetDistanceKilometers();
}
