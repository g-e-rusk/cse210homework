using System;
using System.Collections.Generic;

public class Scripture 
{
    // Private member variable attributes
    private string _reference;
    private List<Word> _word = new List<Word>();

    // Constructors

    public Scripture ()
    {
    }
    public Scripture (string reference, List<Word> _word)
    {
        _reference = reference;
        _word = new List<Word>();
    }

    // Behavior methods for Scripture class

    
    // public void HideWords()
    // {

    // }

    public string GetRenderedText()
    {
        Word _word = new Word();
        return _word.RenderText();
    }

    // public void CompletelyHidden()
    // {

    // }

//     public override string ToString()
//     {
//         return ;
//     }
}