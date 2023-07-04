using System;

public class Reception : Event
{
    // Private member variables
    private string _emailAddress;

    // Constructors
    public Reception(string title, string description, string date, string time, string street, string city, string state, string country, string email) : base(title, description, date, time, street, city, state, country)
    {
        _emailAddress = email;
    }

    // Methods
    public void FullDescription()
    {
        Console.WriteLine($"A {this.GetType()} Event");
        StandardDisplay();
        Console.WriteLine($"Please RSVP to: {_emailAddress}\n");      
    }
}