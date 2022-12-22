using System;
using System.Collections.Generic;

public class Program
{
    private static List<IDrawable> shapes = new List<IDrawable>();
    public static void Main()
    {
        CreateShapes();

        Draw();
    }

    private static void Draw()
    {
        foreach (var s in shapes)
        {
            s.Draw();
        }
    }

    private static void CreateShapes()
    {
        Console.Write("Enter shape count: ");
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter shape info");
            string[] info = Console.ReadLine().Split(' ');
            string type = info[0];
            IDrawable drawable = null;
            switch (type)
            {
                case "c":
                    int radius = int.Parse(info[1]);
                    drawable = new Circle(radius);
                    break;
                case "r":
                    int width = int.Parse(info[1]);
                    int height = int.Parse(info[2]);
                    drawable = new Rectangle(width, height);
                    break;
            }
            shapes.Add(drawable);
        }
    }
}

