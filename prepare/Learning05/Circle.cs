using System;

public class Circle : Shape
{
    // Member Variable
    private double _radius;
    

    // Constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
        
    }

    // Methods
    public override double GetArea()
    {
        return Math.Round(Math.PI * (_radius * _radius));
    }
}