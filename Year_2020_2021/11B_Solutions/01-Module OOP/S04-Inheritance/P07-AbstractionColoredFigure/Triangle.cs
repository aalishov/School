using System;
using System.Collections.Generic;
using System.Text;

public class Triangle : ColoredFigure
{
    public Triangle(string color, double size) : base(color, size)
    {
    }

    public override string GerArea()
    {
        double area = (this.Size * this.Size + Math.Sqrt(3)) / 4;
        return $"{nameof(Triangle)} area: {area}";
    }

    public override string GetName()
    {
        return nameof(Triangle);
    }
}

