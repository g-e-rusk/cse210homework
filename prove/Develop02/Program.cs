using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program.");
        int menuSelection = 0;
        Journal journalEntry = new Journal();

        while (menuSelection != 5) {

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            menuSelection = int.Parse(Console.ReadLine());

            if (menuSelection == 1) {
                Entry e = new Entry();
                e._dateWritten = e.GetDate();
                e._promptUsed = e.GetPrompt();
                e._userResponse = e.GetResponse();
                journalEntry.journal.Add(e);
            }
    
            if (menuSelection == 2) {
                journalEntry.DisplayEntries();
                
            }
    
            if (menuSelection == 3) {
                List<Entry> newEntry = Journal.ReadFromFile();
                foreach (Entry e in newEntry) {
                    Console.WriteLine($"{e._dateWritten} - {e._promptUsed}");
                    Console.WriteLine($"{e._userResponse}");
                }
            }
    
            if (menuSelection == 4) {
                journalEntry.SaveToFile();
            }
        }
    }
}