using System;

public class Running : Activity
{
    // Private member variable
    private double _runningDistance;

    // Constructors
    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _runningDistance = distance;
    }

    // Methods
    public override double GetDistance()
    {
        return _runningDistance;
    }

    public override double GetSpeed()
    {
        return Math.Round((_runningDistance / _activityLength) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round((_activityLength / _runningDistance), 2);
    }
}