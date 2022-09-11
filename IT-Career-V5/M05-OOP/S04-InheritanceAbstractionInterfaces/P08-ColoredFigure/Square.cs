using System;
using System.Collections.Generic;
using System.Text;

public class Square : ColoredFigure
{
    public Square(string color, double size) : base(color, size)
    {
    }
    public override double GetArea()
    {
        return Size * Size;
    }
    public override string GetName()
    {
        return "Square";
    }
}

