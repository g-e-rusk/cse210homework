using System;

public class EternalGoal : Goal
{
    // Member variables inherited from base class

    // Constructors
    public EternalGoal()
    {
        
    }

    // Methods
    // public override void RecordEvent()
    // {
    //     _pointsEarned += _basePoints;
    // }
    public override void DisplayGoals()
    {
        Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
    }
}