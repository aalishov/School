using System;

public class Program
{
    public static void Main()
    {
        double x = 130.0;
        int g = 2010;
        while (x >= 10)
        {
            x *= 0.9;
            g++;
            Console.WriteLine($"Year: {g} -> {Math.Round(x,2)} t ");
        }
        Console.WriteLine($"Year: {g}");
    }
}

