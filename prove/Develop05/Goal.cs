using System;

public class Goal
{
    // Member Variables for base class
    protected string _goalName;
    protected string _goalDescription;
    protected int _basePoints;
    protected int _pointsEarned;
    protected bool _complete = false;

    // Constructors
    public Goal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _basePoints = int.Parse(Console.ReadLine());
    }

    public Goal(int pointsEarned)
    {
        _pointsEarned = pointsEarned;
    }
    
    // Methods
    public virtual int RecordEvent()
    {
       return _pointsEarned += _basePoints;
    }

    public virtual string DisplayGoals()
    {
        return ($"[{GetCompleteChar()}] {_goalName} ({_goalDescription})");
    }

    public char GetCompleteChar()
    {
        if(_complete)
            return 'X';
        else
            return ' ';
    }

    public bool GetComplete()
    {
        return _complete;
    }

    public virtual string DisplayGoalName()
    {
        return _goalName;
    }

    public int GetUserPoints()
    {
        return _pointsEarned;
    }


    public void SetPoints()
    {   
        Console.WriteLine($"You have {GetUserPoints()} points. \n");
    }

    
}