using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rectangle : IDrawable
{
    
    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }

    public int Width { get; private set; }
    public int Height { get; private set; }

    public void Draw()
    {
        Console.WriteLine(new String('*', this.Width));
        for (int i = 0; i < Height - 2; i++)
        {
            Console.WriteLine($"*{new String(' ', this.Width-2)}*");
        }
        Console.WriteLine(new String('*', this.Width));
    }
}

