using System;

public class BreathingActivity : Activity
{
    // Private Member Variables
    private int _breatheInTime;
    private int _breatheOutTime;

    // Constructors
    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }

    // Methods

    public void RunBreathingActivity()
    {
       Console.Clear();
       GetStartMsg(GetDuration());
       
       GetTimer();

       Console.WriteLine("Done");

       
    //    _breatheInTime = 5;
    //    _breatheOutTime = 5;

    //    while (_duration < (_breatheInTime + _breatheOutTime))
    //    {

    //    }


    
    }

}