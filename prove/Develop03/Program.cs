using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("~Welcome to the Scripture Memorizer~");
        Console.WriteLine();
        Reference _reference = new Reference("John", 11, 35);
        Console.Write(_reference.ToString());
        Scripture s = new Scripture();
        Console.WriteLine(" " + s.GetRenderedText());
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string userResponse = Console.ReadLine();
        
        // while (userResponse != "quit")
        // {

        // }

    }
}