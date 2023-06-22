using System;

public class ChecklistGoal : Goal
{
    // Member Variables
    private int _bonusPoints;
    private int _goalNumMax;
    private int _goalCounter = 0;

    // Constructors
    public ChecklistGoal() 
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _goalNumMax = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());

    }

    // Methods
    public override int RecordEvent()
    {
        int totalPoints = _basePoints + _bonusPoints;
        _goalCounter++;

        if (_goalCounter == _goalNumMax)
        {
            _complete = true;
            return _pointsEarned += totalPoints;
        }
        return _pointsEarned += _basePoints;
        
        
    }

    public override string DisplayGoals()
    {
        return ($"[{GetCompleteChar()}] {_goalName} ({_goalDescription}) -- Completed: {_goalCounter}/{_goalNumMax}");
    }

    public override string DisplayGoalName()
    {
        return _goalName;
    }

}