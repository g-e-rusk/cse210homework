using System;

public class SimpleGoal : Goal
{
    // Member Variables
    

    // Constructors
    public SimpleGoal() 
    {
        
    }

    // Methods
    public override int RecordEvent()
    {
        _complete = true;
        return _pointsEarned += _basePoints;
    }

    public override string DisplayGoalName()
    {
        return _goalName;
    }


}