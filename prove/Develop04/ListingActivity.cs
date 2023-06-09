using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _randomPrompt = new List<string>();
    private List<string> _userInput = new List<string>();
    private int _numberOfItems;

    // Constructors
    public ListingActivity(string name, string description) : base(name, description)
    {
        _randomPrompt.Add("Who are people that you appreciate?");
        _randomPrompt.Add("What are personal strengths of yours?");
        _randomPrompt.Add("Who are people you have helped this week?");
        _randomPrompt.Add("When have you felt the Holy Ghost this month?");
        _randomPrompt.Add("Who are some of your personal heroes?");
    }

    // // Methods
    // public string GetRandomPrompt()
    // {
    //     return ;
    // }

    // public void DisplayPrompt()
    // {

    // }

    // public void DisplayNumberofItems() 
    // {

    // }

    public void RunListingActivity()
    {
        Console.Clear();
        GetStartMsg(GetDuration());

    }
}