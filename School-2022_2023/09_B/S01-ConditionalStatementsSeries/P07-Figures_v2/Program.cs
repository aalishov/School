using System;

public class Program
{
    static void Main()
    {
        string figure = Console.ReadLine();
        double result = 0d;

        switch (figure)
        {
            case "rectangle":
                double rectA=double.Parse(Console.ReadLine());
                double rectB = double.Parse(Console.ReadLine());
                result = rectA * rectB;
                break;
            case "square":
                double squareA = double.Parse(Console.ReadLine());
                result = squareA * squareA;
                break;
            case "circle":
                double radius = double.Parse(Console.ReadLine());
                result = Math.Pow(radius, 2) * Math.PI;
                break;
            case "triangle":
                double b = double.Parse(Console.ReadLine());
                double hB = double.Parse(Console.ReadLine());
                result = b * hB / 2.0;
                break;
        }
        Console.WriteLine(result);
    }
}

