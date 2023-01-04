using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle : Shape
{
    public double Weidth { get; private set; }
    public double Height { get; private set; }

    public override double CalculateArea()
    {
        return Weidth*Height;
    }

    public override double CalculatePerimeter()
    {
        return 2*(Height + Weidth);
    }
}

