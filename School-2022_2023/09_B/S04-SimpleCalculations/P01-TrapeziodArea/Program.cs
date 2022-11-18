using System;
public class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        double b1 = double.Parse(Console.ReadLine());
        double b2 = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Red;
        double area = ((b1 + b2) * h) / 2.0;
        //Console.Clear();
        Console.WriteLine($"Trapezoid area = {area}");

    }
}

