using System;

public class EternalGoal : Goal
{
    // Member variables inherited from base class

    // Constructors
    public EternalGoal()
    {
        
    }

    // Methods
    public override int RecordEvent()
    {
        return _pointsEarned += _basePoints;
    }

    public override string DisplayGoalName()
    {
        return _goalName;
    }
}