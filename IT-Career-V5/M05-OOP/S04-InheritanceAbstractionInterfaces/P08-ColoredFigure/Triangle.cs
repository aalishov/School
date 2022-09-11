using System;
public class Triangle : ColoredFigure
{
    public Triangle(string color, double size) : base(color, size)
    {
    }
    public override double GetArea()
    {
        return ((this.Size * this.Size) * Math.Sqrt(3)) / 4.0;
    }

    public override string GetName()
    {
        return "Triangle";
    }
}

