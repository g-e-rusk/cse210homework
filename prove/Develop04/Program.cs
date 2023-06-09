using System;

class Program
{
    static void Main(string[] args)
    {
        int menuResponse = 0;

        Console.Clear();
        while (menuResponse != 4)
        {
            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
        
            string userResponse = Console.ReadLine();
            menuResponse = int.Parse(userResponse);

            while (menuResponse != 4)
            {
                if (menuResponse == 1)
                {
                    BreathingActivity ba = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.");
                    ba.RunBreathingActivity();
                }

                if (menuResponse == 2)
                {
                    ReflectingActivity ra = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    ra.RunReflectingActivity();
                }

                if (menuResponse == 3)
                {
                    ListingActivity la = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having yout list as many things as you can in a certain area.");
                    la.RunListingActivity();
                }
            }
        }
        
    }
}