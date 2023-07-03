using System;

public class LectureEvent : Event
{
    // Private member variables
    private string _speakerName;
    private int _eventCapacity;

    // Constructors
    public LectureEvent(string title, string description, string date, string time, string name, int capacity) : base(title, description, date, time)
    {
        _speakerName = name;
        _eventCapacity = capacity;
    }

    // Methods
    public void FullDescription()
    {
        
    }
}