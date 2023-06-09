using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _randomPrompt = new List<string>();
    private List<string> _randomQuestion = new List<string>();

    // Constructor
    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _randomPrompt.Add("Think of a time when you stood up for someone else.");
        _randomPrompt.Add("Think of a time when you did something really difficult.");
        _randomPrompt.Add("Think of a time when you helped someone in need.");
        _randomPrompt.Add("Think of a time when you did something truly selfless.");


        _randomQuestion.Add("Why was this experience meaningful to you?");
        _randomQuestion.Add("Have you ever done anything like this before?");
        _randomQuestion.Add("How did you get started?");
        _randomQuestion.Add("How did you feel when it was complete?");
        _randomQuestion.Add("What made this time different than other times when you were not as successful?");
        _randomQuestion.Add("What is your favorite thing about this expereience?");
        _randomQuestion.Add("What could you learn from this experience that applies to other situations?");
        _randomQuestion.Add("What did you learn about yourself through this experience?");
        _randomQuestion.Add("How can you keep this experience in mind in the future?");
    }

    // Methods
    public string GetRandomPrompt()
    {
        int index = GenerateRandomIndex();
        while (index > (_randomPrompt.Count))
        {
            GenerateRandomIndex();
        }
        return _randomPrompt[index] ;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public string GetRandomQuestion()
    {
        return _randomQuestion[GenerateRandomIndex()];
    }

    public void DisplayQuestiion()
    {
        Console.WriteLine(GetRandomQuestion());
    }

    public void RunReflectingActivity()
    {
        Console.Clear();
        GetStartMsg(GetDuration());
        DisplayPrompt();
        DisplayQuestiion();


    }

    private int GenerateRandomIndex()
    {
        Random rnd = new Random();
        int number = rnd.Next(1,9);
        return number;
    }
}