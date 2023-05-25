using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Moses", 1, 39);
        Console.Clear();
        Console.WriteLine("~Welcome to the Scripture Memorizer~");
        Console.WriteLine();
        Console.Write(reference.ToString());

        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string userResponse = Console.ReadLine();
        
        // while (userResponse != "quit")
        // {

        // }

    }
}