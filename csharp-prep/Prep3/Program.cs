using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 & 2, user specified number
        // Console.Write("What is the magic number? ");
        //  string response = Console.ReadLine();
        // int magicNumber = int.Parse(response);

        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int userGuess;

        do {
            Console.Write("What is your guess? ");
            string userResponse = Console.ReadLine();
            userGuess = int.Parse(userResponse);

            if (magicNumber > userGuess) {
                Console.WriteLine("Higher");
             }
            else if (magicNumber < userGuess) {
                Console.WriteLine("Lower");
            }
        } while (magicNumber != userGuess);
        
        
        Console.WriteLine("You guessed it!");
        
    }
}