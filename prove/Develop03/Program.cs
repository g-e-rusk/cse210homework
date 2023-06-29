using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("~Welcome to the Scripture Memorizer~");
        Console.WriteLine();
        Reference r = new Reference ("Moses","1","39");
        Scripture s = new Scripture("For behold this is my work and my glory to bring to pass the immortality and eternal life of man.");
        r.GetReference();
        s.DisplayScripture();
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string userResponse = Console.ReadLine();
        bool completlyHidden = false;
        while (userResponse.ToLower() != "quit" || completlyHidden == false)
        {
            Console.Clear();
            int counter = 0;
            while (counter < 3)
            {
                if (s.HideWord())
                {
                    counter++;
                    if (s.CompletelyHidden())
                    {
                        completlyHidden = true;
                        break;
                    }
                }

            }

            r.GetReference();
            s.DisplayScripture();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userResponse = Console.ReadLine();

        }

    }
}