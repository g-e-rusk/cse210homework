using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Gym Forums!");
        Console.WriteLine("You can record and display all workouts here:\n");

        List<Activity> _activityList = new List<Activity>();

        Running running = new Running("06/30/2023", 60, 4);
        _activityList.Add(running);

        Cycling cycling = new Cycling("07/01/2023", 120, 6.8);
        _activityList.Add(cycling);

        Swimming swimming = new Swimming("07/05/2023", 45, 50);
        _activityList.Add(swimming);

        foreach(Activity activity in _activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine();

    }
}