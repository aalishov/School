using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        List<ColoredFigure> figures = new List<ColoredFigure>();

        Console.Write("Enter figures count: ");
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter figure info: ");
            string[] info = Console.ReadLine().Split(' ');
            string type=info[0].ToLower();
            string color = info[1];
            double size = double.Parse(info[2]);
            ColoredFigure figure = null;
            switch (type)
            {
                case"triangle":
                    figure = new Triangle(color, size);
                    break;
                case "square":
                    figure = new Square(color, size);
                    break;
                case "circle":
                    figure = new Circle(color, size);
                    break;
            }
            figures.Add(figure);
        }

        foreach (var figure in figures)
        {
            Console.WriteLine(figure);
        }
    }
}

