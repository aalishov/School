using System;
using System.Collections.Generic;
using System.Text;
public class Circle : ColoredFigure
{
    public Circle(string color, double size) : base(color, size)
    {
    }
    public override double GetArea()
    {
        return Math.PI * Size * Size;
    }
    public override string GetName()
    {
        return "Cirlce";
    }
}

