using System;

class Program
{
    static void Main(string[] args)
    {
        // Calls the welcome function
        DisplayWelcome();

        // Calls the name function
        string userName = PromptUserName();

        // Calls the number function
        int userNumber = PromptUserNumber();

        // Calls the square function
        int squaredNumber = SquareNumber(userNumber);

        // Calls the display function
        DisplayResult(userName, squaredNumber);


    }

    // Function to display welcome message
    static void DisplayWelcome() 
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Fucntion to prompt for user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function to prompt for user number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;

    }

    // Function to square the user number
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // Function to display the result
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the sqaure of your number is {square}.");
    }
}