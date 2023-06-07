using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        
        // string userResponse = Console.ReadLine();
        // int menuResponse = int.Parse(userResponse);

        // while (menuResponse != 4)
        // {
        //     if (menuResponse == 1)
        //     {
                BreathingActivity ba = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.");
                ba.RunBreathingActivity();
            //}

       // }
        
    }
}