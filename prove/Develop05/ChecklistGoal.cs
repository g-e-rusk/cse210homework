using System;

public class ChecklistGoal : Goal
{
    // Member Variables
    private int _bonusPoints;
    private int _goalNumMax;
    private int _goalCounter;

    // Constructors
    public ChecklistGoal() 
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _goalNumMax = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());

    }

    // Methods
    // public override void RecordEvent()
    // {
    //     base.RecordEvent();
    // }

    // public override bool IsComplete()
    // {
    //     return base.IsComplete();
    // }

    // public int GetGoalCounter()
    // {
    //     return ;
    // }

    // public int GetGoalNumMax()
    // {
    //     return ;
    // }

}