using System;

public class Word 
{
    // Private member variable attribute
    private string _word;
    private bool _hidden;


    // Constructor

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }


    // Behavior attributes for the Word class
    public void HideWord()
    {
        _hidden = true;
    }

    public void RenderText()
    {
        if (_hidden == true)
        {
            foreach(char letter in _word) 
            {
                Console.Write("_");
            }
           
        }
        else 
        {
            Console.Write($"{_word}");
        }
    }

    public bool GetHidden()
    {
        return _hidden;
    }
}