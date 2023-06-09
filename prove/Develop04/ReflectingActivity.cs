using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _randomPrompt = new List<string>()
    {"Think of a time when you stood up for someone else.",
     "Think of a time when you did something really difficult.",
     "Think of a time when you helped someone in need.",
     "Think of a time when you did something truly selfless."
    };
    private List<string> _randomQuestion = new List<string>()
    {"Why was this experience meaningful to you?",
     "Have you ever done anything like this before?",
     "How did you get started?",
     "How did you feel when it was complete?",
     "What made this time different than other times when you were not as successful?",
     "What is your favorite thing about this experience?",
     "What could you learn from this experience that applies to other situations?",
     "What did you learn about yourself through this experience?",
     "How can you keep this experience in mind in the future?"
    };

    // Constructor
    public ReflectingActivity()
    {
        _activityName = "Reflecting";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience.  \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
        
    }

    // Methods
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_randomPrompt.Count);
        return _randomPrompt[index] ;
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_randomQuestion.Count);
        return _randomQuestion[index];
    }

    public void RunReflectingActivity()
    {
        Console.Clear();
        GetStartMsg();
        Console.WriteLine("Think about this prompt for a moment:\n");
        Console.WriteLine($">{GetRandomPrompt()}");
        Console.WriteLine("\nPress enter when you are ready.");
        Console.ReadLine();

        // Using the built-in Stopwatch class which allows us to keep track of time after the user presses the enter key.
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int counter = 0;
        Console.CursorVisible = false;
        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            Console.WriteLine(GetRandomQuestion());
            GetTimer(10);
            counter++;
        } 

        stopwatch.Stop();
        Console.CursorVisible = true;
        GetEndMsg();


    }
}