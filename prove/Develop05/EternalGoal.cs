using System;

public class EternalGoal : Goal
{
    // Member variables inherited from base class

    // Constructors
    public EternalGoal()
    {
        
    }

    public EternalGoal(string goalName, string goalDescription, int basePoints) : base(goalName, goalDescription, basePoints)
    {

    }

    // Methods
    public override int RecordEvent()
    {
        return _basePoints;
    }

    public override string DisplayGoalName()
    {
        return _goalName;
    }
}