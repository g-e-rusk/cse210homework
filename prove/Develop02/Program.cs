using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program.");

        // while {
        //     Console.WriteLine("Please select one of the following choices:");
        //     Console.WriteLine("1. Write");
        //     Console.WriteLine("2. Display");
        //     Console.WriteLine("3. Load");
        //     Console.WriteLine("4. Save");
        //     Console.WriteLine("5. Quit");
        //     Console.Write("What would you like to do? ");
        // }
        
        Entry entry = new Entry();
        entry.DisplayEntry();
    }
}