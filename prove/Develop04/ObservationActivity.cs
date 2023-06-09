using System;

public class ObservationActivity : Activity
{
    private string _object;

    public ObservationActivity() 
    {
        _activityName = "Observation";
        _activityDescription = "This activity will help you to clear you mind while admiring God's creations.";
    }

    public void RunObservationActivity()
    {
        Console.Clear();
        GetStartMsg();
        Console.WriteLine();

        Console.WriteLine("Pick a natural object near you that you can focus on.");
        Console.Write("What object will you be focusing on? ");
        _object = Console.ReadLine();
        Console.WriteLine($"Concentrate on every aspect of your {_object}.  When you are ready to begin, clear your mind and press enter.");
        Console.CursorVisible = false;
        Console.ReadLine();
        GetTimer(_duration);
        Console.CursorVisible = true;
        GetEndMsg();



    }




}