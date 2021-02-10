using System;

public class Program
{
    public static void Main()
    {
        string figure = Console.ReadLine();
        double s = 0;

        if (figure == "square")
        {
            double a = double.Parse(Console.ReadLine());
            s = a * a;
        }
        else if (figure == "rectangle")
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            s = a * b;
        }
        else if (figure == "circle")
        {
            double r = double.Parse(Console.ReadLine());
            s = Math.PI * Math.Pow(r, 2);
        }
        else if (figure == "triangle")
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            s = a * h / 2;
        }
        Console.WriteLine(Math.Round(s, 3));
    }
}

