using System;

class Program
{


    static void Main(string[] args)
    {   
        int userResponse = 0;

        while (userResponse != 6)
        {
        Console.Clear();
        Console.WriteLine("Welcome to Eternal Quest - A Goal Setting Program \n");
        Console.WriteLine("You have 0 points. \n");
        Console.WriteLine("Menu Options: \n");
        Console.WriteLine("1.  Create New Goal \n2.  List Goals \n3.  Save Goals \n4.  Load Goals \n5.  Record Event \n6.  Quit \n"); 
        Console.Write("Select a choice from the menu: ");
        userResponse = int.Parse(Console.ReadLine());

        List<Goal> _goalList = new List<Goal>();

        if (userResponse == 1)
        {
            Console.WriteLine("\nThe types of Goals are: ");
            Console.WriteLine("1.  Simple Goal \n2.  Eternal Goal \n3.  Checklist Goal \n");
            Console.Write("Please make a selection from the menu: ");
            int userAnswer = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (userAnswer == 1)
            {
                SimpleGoal s = new SimpleGoal();
                _goalList.Add(s);
            }

            if (userAnswer == 2)
            {
                EternalGoal g = new EternalGoal();
                _goalList.Add(g);
            }

            if (userAnswer == 3)
            {
                ChecklistGoal c = new ChecklistGoal();
                _goalList.Add(c);
            }
        } 

        if (userResponse == 2)
        {
            foreach (Goal goal in _goalList)
            {
                Console.WriteLine($"{_goalList}");
            }
        }

        if (userResponse == 3)
        {

        }

        if (userResponse == 4)
        {

        }

        if (userResponse == 5)
        {

        }

        }


        
    }
}