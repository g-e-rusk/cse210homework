using System;

// BASE CLASS for all other classes
public class Activity
{
    // Private member variables
    protected string _activityName;
    protected string _activityDescription;
    private List<string> animationStrings = new List<string>()
    {"|", "/", "-", "\\"};
    protected int _duration;



    // Methods
    public void GetStartMsg() // This is the starting message that will initiate when the person chooses a number from the main menu.
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine();
        Console.WriteLine($"{_activityDescription}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.Write("Get Ready...");
        GetPauseAnimation(5);
        Console.WriteLine("\n");
    }

    public void GetEndMsg() // This is the ending message which ends each activity.
    {
        Console.WriteLine("Well done!!");
        GetPauseAnimation(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName} Activity.");
        GetPauseAnimation(5);
    }

    public void GetTimer(int duration) // Used in the Reflecting and Observation class activities
    {        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write(duration);
            Thread.Sleep(1000);
            Console.Write("\b\b \b");
            duration--;
        }
    }

    

    public void GetPauseAnimation(int duration) // Called when each program starts and ends as part of the Start and End Messages
    {
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;
        int x = 0;
        Console.CursorVisible = false;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[x];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;
            x = i % 4;

        }
        Console.CursorVisible = true;
    }

    public void GetCountdown(int countdownTime) // Used in the breathing activity
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(countdownTime);
        Console.CursorVisible = false;
        while (DateTime.Now < futureTime)
        {
            Console.Write(countdownTime);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            countdownTime--;
        }
        Console.CursorVisible = true;
    }
}