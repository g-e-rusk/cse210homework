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
            Console.WriteLine("  1. Start Breathing activity");
            Console.WriteLine("  2. Start Reflection activity");
            Console.WriteLine("  3. Start Listing activity");
            Console.WriteLine("  4. Start Observation activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
        
            string userResponse = Console.ReadLine();
            menuResponse = int.Parse(userResponse);

            while (menuResponse != 5)
            {
                if (menuResponse == 1)
                {
                    BreathingActivity ba = new BreathingActivity();
                    ba.RunBreathingActivity();
                }

                if (menuResponse == 2)
                {
                    ReflectingActivity ra = new ReflectingActivity();
                    ra.RunReflectingActivity();
                }

                if (menuResponse == 3)
                {
                    ListingActivity la = new ListingActivity();
                    la.RunListingActivity();
                }

                if (menuResponse == 4)
                {
                    ObservationActivity oa = new ObservationActivity();
                    oa.RunObservationActivity();
                }
            }
        }
        
    }
}