using System;
using System.Collections.Generic;
using System.Text;


public abstract class ColoredFigure
{
    protected ColoredFigure(string color, double size)
    {
        this.Color = color;
        this.Size = size;
    }

    public string Color { get; set; }

    public double  Size { get; set; }

    public string Show()
    {
        return $"{this.Color} {this.Size}";
    }

    public abstract string GetName();

    public abstract string GerArea();
}

