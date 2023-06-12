using System;

class Program
{
    static void Main(string[] args)
    {
        // Square s1 = new Square("red", 4);
        // Console.WriteLine($"{s1.GetColor()} {s1.GetArea()}");

        // Rectangle r1 = new Rectangle("green", 5, 9);
        // Console.WriteLine($"{r1.GetColor()} {r1.GetArea()}");

        // Circle c1 = new Circle("yellow", 5);
        // Console.WriteLine($"{c1.GetColor()} {c1.GetArea()}");

        List<Shape> _shapes = new List<Shape>();
        _shapes.Add(new Square("Red", 4));
        _shapes.Add(new Rectangle("Green", 5, 9));
        _shapes.Add(new Circle("Yellow", 3));

        foreach(Shape shape in _shapes)
        {
            string coloredShape = shape.GetColor();
            double shapeArea = shape.GetArea();
            Console.WriteLine($"The {coloredShape} shape has an area of {shapeArea}.");
        }
        
    }
}