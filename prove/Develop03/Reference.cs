using System;

public class Reference
{
    // Private member variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    // Constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Behavior method for getting the reference
    public string GetReference()
    {
            return _book + " " + _chapter + ":" + _verse;
        
    }
    
    public override string ToString()
    {
        return GetReference();
     }

}