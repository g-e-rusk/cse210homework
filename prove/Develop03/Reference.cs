using System;

public class Reference
{
    // Private member variables
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;


    // Constructors
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Behavior method for getting the reference
    
    public void GetReference()
    {
        if (_endVerse == "0")
        {
            Console.Write($"{_book} {_chapter}:{_verse}");
            
        } else
        {
            Console.Write($"{_book} {_chapter}:{_verse}-{_endVerse}");
        }
        
     }

}