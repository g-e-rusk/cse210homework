using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Grade Calculator");
        Console.WriteLine();
        Console.Write("What is your grade percentage? ");
        string percent = Console.ReadLine();
        int gradePercent = int.Parse(percent);

        string grade = "";

        if (gradePercent >= 90)
        {
            grade = "A";
        }
        else if (gradePercent >= 80 && gradePercent < 90)
        {
            grade = "B";
        }
        else if (gradePercent >= 70 && gradePercent < 80)
        {
            grade = "C";
        }
        else if (gradePercent >= 60 && gradePercent < 70)
        {
            grade = "D";
        }
        else
        {
           grade = "F";
        }

        Console.WriteLine();
        Console.WriteLine($"Your grade is {grade}.");
        
        


        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
            Console.WriteLine();
        }
        else {
            Console.WriteLine("Better luck next time.");
            Console.WriteLine();
        }
    }


}