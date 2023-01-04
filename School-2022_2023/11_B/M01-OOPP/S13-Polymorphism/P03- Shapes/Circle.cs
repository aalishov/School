using System;

public class Circle : Shape
{
    public double Radius { get; private set; }
    
    public override double CalculateArea()
    {
        return Math.PI * Radius*Radius;
    }

    public override double CalculatePerimeter()
    {
        return Math.PI * Radius * 2;
    }
}

