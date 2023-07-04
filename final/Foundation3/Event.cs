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
    public Event(string title, string description, string date, string time, string street, string city, string state, string country)
    {
        _eventTitle = title;
        _eventDescription = description;
        _eventDate = date;
        _eventTime = time;
        _eventAddress = new Address (street, city, state, country);
        
    }
    // Methods
    public Address AddressDisplay()
    {
        return _eventAddress;
    }

    public void StandardDisplay()
    {
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Description: {_eventDescription}");
        Console.WriteLine($"Date: {_eventDate}");
        Console.WriteLine($"Time: {_eventTime}");
        Console.Write($"Address: {AddressDisplay().GetAddressDisplay()}\n");


    }

    public void ShortDescription()
    {
        Console.WriteLine($"A {this.GetType()} Event");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Date: {_eventDate}\n");

    }
}