using System;

public class Activity
{
    // Private member variables
    private string _activityName;
    private string _activityDescription;
    protected int _duration;

    // Constructors
    public Activity (string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // Methods
    public void GetStartMsg(int duration)
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine();
        Console.WriteLine($"{_activityDescription}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.Write("Get Ready...");
        GetPauseAnimation();
    }

    public void GetTimer()
    {        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        for (int i = _duration; i > 0; i-- )
        {
            Console.Write(".");
        }
        
        Thread.Sleep(_duration * 1000);
    }
        

    public void GetEndMsg() 
    {
        Console.WriteLine("Well done!!");
        GetPauseAnimation();
        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName} Activity.");
        GetPauseAnimation();
    }

    public void GetPauseAnimation()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;
        Console.CursorVisible = false;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
        Console.CursorVisible = true;
    }

    public void GetPauseCountdown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
    }

}