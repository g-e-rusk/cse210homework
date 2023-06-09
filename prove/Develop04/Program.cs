using System;

class Program
{
    static void Main(string[] args)
    {
        int menuResponse = 0;

        // Creating the main menu. As long as the user does not type 5, the program will run in a loop until the user enters 5.
        while (menuResponse != 5)
        {   
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing activity");
            Console.WriteLine("  2. Start Reflection activity");
            Console.WriteLine("  3. Start Listing activity");
            Console.WriteLine("  4. Start Observation activity"); // EXTRA!  This exceeds the requirements because it is another activity which follows the same principles of the other examples.
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            string userResponse = Console.ReadLine();
            menuResponse = int.Parse(userResponse);


            while (menuResponse == 1)
            {
                // Instantiating the BreathingActivity class
                BreathingActivity ba = new BreathingActivity();
                ba.RunBreathingActivity();
                break;
            }

            while (menuResponse == 2)
            {
                // Instantiating the ReflectingActivity class
                ReflectingActivity ra = new ReflectingActivity();
                ra.RunReflectingActivity();
                break;
            }

            while (menuResponse == 3)
            {
                //Instantiating the Listing Activity class
                ListingActivity la = new ListingActivity();
                la.RunListingActivity();
                break;
            }

            while (menuResponse == 4)
            {
                // EXTRA: Instantiating the Oberservation class.  This is an extra class which will allow the user to focus on one thing in nature.
                ObservationActivity oa = new ObservationActivity();
                oa.RunObservationActivity();
                break;
            }

        }


    }
}
