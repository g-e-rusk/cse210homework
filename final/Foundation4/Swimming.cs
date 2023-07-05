using System;

public class Swimming : Activity
{
    // Private member variables
    private int _swimmingLaps;

    // Constructors
    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _swimmingLaps = laps;
    }

    // Methods
    public override double GetDistance()
    {
        return Math.Round(_swimmingLaps * 50 / 1000 * 0.62, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round((GetDistance() / _activityLength) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(_activityLength / GetDistance(), 2);
    }
}