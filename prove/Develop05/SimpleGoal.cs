using System;

public class SimpleGoal : Goal
{
    // Member Variables
    

    // Constructors
    public SimpleGoal() 
    {
        
    }

    public SimpleGoal(string goalName, string goalDescription, int basePoints, bool _complete) : base(goalName, goalDescription, basePoints)
    {
        _complete = GetComplete();
    }

    // Methods
    public override int RecordEvent()
    {
        _complete = true;
        return _basePoints;
    }

    public override string DisplayGoalName()
    {
        return _goalName;
    }

    public override string GetStringRepresentation()
    {
        string goalType = GetType().Name;
        return ($"{goalType}||{_goalName}||{_goalDescription}||{_basePoints}||{_complete}");
    }


}