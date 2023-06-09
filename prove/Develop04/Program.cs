using System;

class Program
{
    static void Main(string[] args)
    {
        int menuResponse = 0;

        
        while (menuResponse != 5)
        {   
            Console.Clear();
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


            while (menuResponse == 1)
            {
                BreathingActivity ba = new BreathingActivity();
                ba.RunBreathingActivity();
                break;
            }

            while (menuResponse == 2)
            {
                ReflectingActivity ra = new ReflectingActivity();
                ra.RunReflectingActivity();
                break;
            }

            while (menuResponse == 3)
            {
                ListingActivity la = new ListingActivity();
                la.RunListingActivity();
                break;
            }

            while (menuResponse == 4)
            {
                ObservationActivity oa = new ObservationActivity();
                oa.RunObservationActivity();
                break;
            }

        }


    }
}
