using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating a new list that the user can add to
        List<int> numbers = new List<int>();

        // Instructions for the user
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        // Setting the variable
        int userNum;

        // do-while loop for user to continue entering numbers until they enter 0
        do {
            Console.Write("Enter number: "); 
            string response = Console.ReadLine();
            userNum = int.Parse(response);

            if (userNum != 0) {
                numbers.Add(userNum); // Adds the number to the list until they enter 0
                } 
            } while (userNum != 0) ;

            // Setting the sum variable
            int sum = 0;

            // foreach loop to continue adding each number to the previous sum
            foreach (int number in numbers) {
                sum += number;
            }
            Console.WriteLine($"The sum is {sum}.");


            // To get the average, set the variable to a float so that decimal places can be included
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is {average}.");

            // The max number variable is set 
            int max = numbers[0];

            // Loop through the list and find the maximum number
            foreach (int number in numbers) {
                if (number > max) {
                    max = number;
                }
            }
            Console.WriteLine($"The largest number is {max}.");

            // The min number variable is set
            int min = numbers[0];

            // Loop through the list and find the minimum positive number
            foreach (int number in numbers) {
                if (number >= 0) {
                    min = number;
                }
            }
            Console.WriteLine($"The smallest positive number is: {min}");

            // Sorting the numbers in ascending order
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];
                Console.WriteLine(number);
            }
    }  
}