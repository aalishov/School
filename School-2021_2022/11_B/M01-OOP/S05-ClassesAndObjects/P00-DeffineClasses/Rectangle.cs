using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle
{
    private int width;
    public int Width
    {
        get { return width; }
        set { this.width = value; }
    }
    public int Height { get; set; }
    public string Color { get; set; }

    private int CalculateArea()
    {
        return Width * Height;
    }

    public string PrintArea()
    {
        return $"Rectangle area = {CalculateArea()}";
    }
}

