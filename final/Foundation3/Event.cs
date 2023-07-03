using System;

public class Event
{
    // Private member variables
    private string _eventTitle;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime;
    private Address _eventAddress;

    // Constructors
    public Event(string title, string description, string date, string time)
    {
        _eventTitle = title;
        _eventDescription = description;
        _eventDate = date;
        _eventTime = time;
        
    }
    // Methods
    public void AddressDisplay()
    {
        _eventAddress = new Address("", "", "", "");
        Console.WriteLine(_eventAddress.AddressDisplay());
    }

    public void StandardDisplay()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Premier Events Marketing");
        Console.WriteLine("Our next event will be:\n");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Description: {_eventDescription}");
        Console.WriteLine($"Date: {_eventDate}");
        Console.WriteLine($"Time: {_eventTime}");
        Console.WriteLine($"Address: {_eventAddress}");

    }

    public void ShortDescription()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Premier Events Marketing");
        Console.WriteLine("Our next event will be:\n");
        Console.WriteLine($"A {this.GetType()} Event");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Date: {_eventDate}");

    }
}