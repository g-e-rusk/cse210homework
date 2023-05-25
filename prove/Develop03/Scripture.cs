using System;
using System.Collections.Generic;

public class Scripture 
{
    // Private member variable attributes
    private string _reference;
    private List<Word> _word = new List<Word>();

    // Constructors
    public Scripture(string reference, List<Word> word)
    {
        _reference = reference;
        _word = word;
    }


    // Behavior methods for Scripture class

    public void HideWords()
    {

    }

//     public string GetRenderedText()
//     {
//         return ;
//     }

    public void CompletelyHidden()
    {

    }

//     public override string ToString()
//     {
//         return ;
//     }
}