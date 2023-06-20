using System;

public class SimpleGoal : Goal
{
    // Member Variables
    protected bool _complete = false;

    // Constructors
    public SimpleGoal() 
    {
        
    }

    // Methods
    // public override void RecordEvent()
    // {
    //     base.RecordEvent();
    // }

    // public override bool IsComplete()
    // {
    //     _complete = true;
    // }

    public override void DisplayGoals()
    {
        Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
    }


}