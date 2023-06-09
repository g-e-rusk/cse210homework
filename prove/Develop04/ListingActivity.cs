using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _randomPrompt = new List<string>()
    {"Who are people that you appreciate?",
     "What are personal strengths of yours?",
     "Who are people you have helped this week?",
     "When have you felt the Holy Ghost this month?",
     "Who are some of your personal heroes?"
    };

    // Constructors
    public ListingActivity() 
    {
       _activityName = "Listing";
       _activityDescription = "This activity will help you reflect on the good things in your life by having yout list as many things as you can in a certain area.";
    }

    // // Methods

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_randomPrompt.Count);
        return _randomPrompt[index];
    }

    public void RunListingActivity() // Main method called when this class is instantiated.  Also uses the Stopwatch buil-in class for keeping the timing of the activity.
    {
        Console.Clear();
        GetStartMsg();
        Console.WriteLine(GetRandomPrompt());
       
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int counter = 0;
        
        
        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            Console.Write(">");
            Console.ReadLine();
            counter++;
        } 

        Console.WriteLine($"\nYou listed {counter} items.");

        stopwatch.Stop();

        GetEndMsg();

        

    }
}