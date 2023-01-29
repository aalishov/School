using System;

public class Program
{
    static void Main()
    {
        string figure = Console.ReadLine();
        double result = 0d;
        if (figure == $"square")
        {
            double a = double.Parse(Console.ReadLine());
            result = a * a;
        }
        else if (figure == $"rectangle")
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            result = a * b;
        }
        else if (figure == $"circle")
        {
            double r = double.Parse(Console.ReadLine());
            result = Math.Pow(r,2) * Math.PI;
        }
        else if (figure == $"triangle")
        {
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            result = b * h / 2.0;
        }
        Console.WriteLine(result);
    }
}

