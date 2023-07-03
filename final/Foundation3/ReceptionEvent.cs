using System;

public class ReceptionEvent : Event
{
    // Private member variables
    private string _emailAddress;

    // Constructors
    public ReceptionEvent(string title, string description, string date, string time, string email) : base(title, description, date, time)
    {
        _emailAddress = email;
    }

    // Methods
    public string GetSpeaker()
    {
        return _emailAddress;
    }

    public void SetSpeaker(string email)
    {
        _emailAddress = email;
    }
}