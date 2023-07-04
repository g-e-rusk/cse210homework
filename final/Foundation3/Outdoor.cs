using System;

public class Outdoor : Event
{
    // Private member variables
    private string _weatherForecast;

    // Constructors
    public Outdoor(string title, string description, string date, string time, string street, string city, string state, string country, string forecast) : base(title, description, date, time, street, city, state, country)
    {
        _weatherForecast = forecast;
    }

    // Methods
    public void FullDescription()
    {
        Console.WriteLine($"A {this.GetType()} Event");
        StandardDisplay();
        Console.WriteLine($"Please note the weather forecast: {_weatherForecast}\n");      
    }
}