using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<ColoredFigure> figures= new List<ColoredFigure>();

        Triangle figure1 = new Triangle("Red",3);
        Square figure2 = new Square("Blue", 3);
        Triangle figure3 = new Triangle("Black", 3);
        Triangle figure4 = new Triangle("White", 7);

        figures.Add(figure1);
        figures.Add(figure2);
        figures.Add(figure3);
        figures.Add(figure4);

        foreach (var f in figures)
        {
            Console.WriteLine(f.Show() +" => " +f.GerArea() );
        }
    }
}

