using System;

public class OutdoorEvent : Event
{
    // Private member variables
    private string _weatherForecast;

    // Constructors
    public OutdoorEvent(string title, string description, string date, string time, string forecast) : base(title, description, date, time)
    {
        _weatherForecast = forecast;
    }

    // Methods
    public string GetForecast()
    {
        return _weatherForecast;
    }

    public void SetForecast(string forecast)
    {
        _weatherForecast = forecast;
    }
}