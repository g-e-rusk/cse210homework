using System;

public class BreathingActivity : Activity
{
    // Private Member Variables
    private int _breatheInTime = 5;
    private int _breatheOutTime = 5;

    // Constructors
    public BreathingActivity()
    {
        _activityName = "Breathing";
        _activityDescription = "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.";
    }

    // Methods

    public void RunBreathingActivity()  // Main method for when the class is instantiated
    {
       Console.Clear();
       GetStartMsg();
       Console.WriteLine();

       int duration = _duration;
       while (duration > 0)
       {
            Console.Write("Breath in...");
            GetCountdown(_breatheInTime);
            Console.WriteLine("\n");
            Console.Write("Breath out...");
            GetCountdown(_breatheOutTime);
            Console.WriteLine("\n");
            duration -= _breatheInTime + _breatheOutTime;
       }

       GetEndMsg();
    }

}