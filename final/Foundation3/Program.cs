using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Premier Events Marketing");
        Console.WriteLine("Our next event will be: \n");

        Lecture le1 = new Lecture("Investing for the Future", "Learn how to invest, where to invest and with whom to invest to shape the future you want", "August 30, 2023", "5:00 p.m.", "352 Wilkenson Drive", "Fairville", "GA", "USA", "Mr. John Fredricks", 300);

        Console.WriteLine("Standard Details:");
        le1.StandardDisplay();

        Console.WriteLine();
        Console.WriteLine("Full Description:");
        le1.FullDescription();

        Console.WriteLine("Short Description:");
        le1.ShortDescription();

        Console.WriteLine("----------------------------------------------------");

        Reception re1 = new Reception("UC Davis Health and Merck Partnership Reception", "Join us as we celebrate the partnership between UC Davis Health and Merck", "September 15, 2023", "7:00 p.m.", "5 Main Street", "Davis", "CA", "USA", "ucdpartners@UCDavis.edu");

        Console.WriteLine("Standard Details:");
        re1.StandardDisplay();

        Console.WriteLine();
        Console.WriteLine("Full Description:");
        re1.FullDescription();

        Console.WriteLine("Short Description:");
        re1.ShortDescription();


        Console.WriteLine("----------------------------------------------------");

        Outdoor oe1 = new Outdoor("Mr. & Mrs. Hank Smith's Outdoor Wedding", "Join us as we celebrate the union of Hank Smith and Joanna Grace as man and wife", "October 3, 2023", "2:00 p.m.", "8700 Wishing Well Way", "Mill Valley", "CA", "USA", "Temperatures in the low 50s to high 80s with bright sun.  Hats and umbrellas encouraged.");

        Console.WriteLine("Standard Details:");
        oe1.StandardDisplay();

        Console.WriteLine();
        Console.WriteLine("Full Description:");
        oe1.FullDescription();

        Console.WriteLine("Short Description:");
        oe1.ShortDescription();

    }
}