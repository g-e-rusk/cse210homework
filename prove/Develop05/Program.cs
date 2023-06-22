using System;
using System.Collections.Generic;

class Program
{


    static void Main(string[] args)
    {   
        int userResponse = 0;
        List<Goal> _goalList = new List<Goal>();

        Console.Clear();
        Console.WriteLine("Welcome to Eternal Quest - A Goal Setting Program \n");

        while (userResponse != 6)
        {
        Goal goal = new Goal(0);
        goal.SetPoints();
        Console.WriteLine("Menu Options: \n");
        Console.WriteLine("1.  Create New Goal \n2.  List Goals \n3.  Save Goals \n4.  Load Goals \n5.  Record Event \n6.  Quit \n"); 
        Console.Write("Select a choice from the menu: ");
        userResponse = int.Parse(Console.ReadLine());

        
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
            for(int i=0; i<_goalList.Count; i++)
            {
                Console.WriteLine(_goalList[i].DisplayGoals());
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
            Console.WriteLine("The goals are: ");
            List<int> indexes = new List<int>();
            // 0    1   2   3   4   ...
            // 2    4   5   7   10
            int counter = 1;
            for(int i=0; i<_goalList.Count; i++)
            {
                if (!_goalList[i].GetComplete())
                {
                    Console.WriteLine($"{counter}. {_goalList[i].DisplayGoalName()}");
                    indexes.Add(i);
                    counter++;
                }
            }

            Console.Write("Which goal did you accomplish? ");
            int completedGoal = int.Parse(Console.ReadLine());
            _goalList[indexes[completedGoal - 1]].RecordEvent();

            
        }

        }
        

        
    }
}