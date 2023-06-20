using System;

public class Goal
{
    // Member Variables for base class
    protected string _goalName;
    protected string _goalDescription;
    protected int _basePoints;
    protected int _pointsEarned;

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
    
    // Methods
    // public virtual void RecordEvent()
    // {

    // }

    // public virtual bool IsComplete()
    // {

    // }

    public int GetPoints()
    {
        return _basePoints;
    }

    public void SetPoints()
    {

    }

    // public void GetMaxGoal()
    // {

    // }

    // public string GetGoals()
    // {
    //     return ;
    // }

    // public void SetGoals()
    // {

    // }
}