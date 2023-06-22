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

    public ChecklistGoal(string goalName, string goalDescription, int basePoints, int bonusPoints, int goalNumMax, int goalCounter) : base(goalName, goalDescription, basePoints)
    {
        _bonusPoints = bonusPoints;
        _goalNumMax = goalNumMax;
        _goalCounter = goalCounter;
    }

    // Methods
    public override int RecordEvent()
    {
        int totalPoints = _basePoints + _bonusPoints;
        _goalCounter++;

        if (_goalCounter == _goalNumMax)
        {
            _complete = true;
            return totalPoints;
        }
        return _basePoints;
        
        
    }

    public override string DisplayGoals()
    {
        return ($"[{GetCompleteChar()}] {_goalName} ({_goalDescription}) -- Completed: {_goalCounter}/{_goalNumMax}");
    }

    public override string DisplayGoalName()
    {
        return _goalName;
    }

    public override string GetStringRepresentation()
    {
        string goalType = GetType().Name;
        return ($"{goalType}||{_goalName}||{_goalDescription}||{_basePoints}||{_bonusPoints}||{_goalNumMax}||{_goalCounter}");
    }
}