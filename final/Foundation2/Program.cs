using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Click and Ship");
        Console.WriteLine();
        Order c1 = new Order("Carolyn Brown", "123 Main Street", "Avocadodale", "MI", "USA");
        c1.AddProduct("Effortless Pans", "EP589", 18.99, 2);
        c1.AddProduct("Fruit Saver", "FS879", 5.89, 3);
        c1.AddProduct("Tie Dye Socks", "TDS55", 6.79, 1);
        c1.AddProduct("Glow-in-the-Dark Paint Set", "GDPS8", 15.78, 1);
        c1.PrintPackingSlip();
        Console.WriteLine();
        c1.PrintShippingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total Order Price: ${c1.TotalOrderPrice()}");

        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXX");
        Order c2 = new Order("Jacques Heiver", "118 Boulevard Jourdan", "Paris", "75006", "FRANCE");
        c2.AddProduct("Iron Gorge Spatula", "IGSC63", 5.26, 3);
        c2.AddProduct("Custom-made Blinds", "CMB77", 58.99, 6);
        c2.AddProduct("Antique Grandfather Clock", "AGC00", 200.58, 1);
        c2.AddProduct("German Waffle Maker", "GWM45", 56.47, 1);
        c2.PrintPackingSlip();
        Console.WriteLine();
        c2.PrintShippingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total Order Price: ${c2.TotalOrderPrice()}");
        Console.WriteLine();



        
    }
}