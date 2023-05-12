// This is the template for my Journal class
// This will add an entry, display all the entries, save to a file and load from a file
// Calls the Entry display method
using System;
using System.Collections.Generic;
using System.IO;

public class Journal {

    public List<Entry> journal = new List<Entry>();
        
        

    public Journal() 
    {
        
    }

    
    // Method to call EntryDisplay for all journal entries in the journal.
    public void DisplayEntries() {
        foreach (Entry entry in journal) {
            entry.DisplayEntry();
        }
    }


    // Method to save to a file with user supplied filename
    public void SaveToFile()
    {
        Console.Write("Please enter your filename as a .txt: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Entry journalEntry in journal)
            {
                outputFile.WriteLine($"{journalEntry._dateWritten}||{journalEntry._promptUsed}||{journalEntry._userResponse}");
            }
        }
    }

    // Method to load a file and read from the file
    public static List<Entry> ReadFromFile() {

        List<Entry> allEntries = new List<Entry>();

        Console.Write("Please enter your filename as a .txt: ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("||");

            Entry newEntry = new Entry();
            newEntry._dateWritten = parts[0];
            newEntry._promptUsed = parts[1];
            newEntry._userResponse = parts[2];


        }

        return allEntries;
    }

}


    