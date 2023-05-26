using System;
using System.Collections.Generic;

public class Scripture 
{
    // Private member variable attributes
    private Reference _reference;
    private Random random = new Random();
    private List<Word> _words = new List<Word>();

    // Constructors
    public Scripture(string text)
    {
        string[] words = text.Split(' ');
        
        foreach (string word in words)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }

        _reference = new Reference("Moses", "1", "39");

           
    }

    // Behavior methods for Scripture class

    
    public bool HideWord()
    {
        int index = random.Next(_words.Count);
        //Word word = _words[index];
        if (!_words[index].GetHidden())
        {
            _words[index].HideWord();
            return true;
        }
        return false;

    }

    public void DisplayScripture()
    {
        foreach ( Word word in _words)
        {
            word.RenderText();
            Console.Write(" ");
        }
    }

    public bool CompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.GetHidden())
            {
                return false;
            }
        }
        return true;
    }

}