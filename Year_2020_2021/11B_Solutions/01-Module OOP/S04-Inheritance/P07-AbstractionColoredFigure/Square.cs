using System;
using System.Collections.Generic;
using System.Text;

public class Square : ColoredFigure
{
    public Square(string color, double size) : base(color, size)
    {
    }

    public override string GerArea()
    {
        double area = this.Size * this.Size;
        return $"{nameof(Square)} area: {area}";
    }

    public override string GetName()
    {
        return nameof(Square);
    }
}

