using System;

class Program
{
    static void Main()
    {
        double x = 20;
        int g = 1990;
        while (x >= 5)
        {
            x *= 0.8;
            g += 2;
        }
        Console.WriteLine($"Year < 5t: {g}");

        x = 20;
        g = 1990;
        double sum = 20;
        while (sum <= 90)
        {
            x *= 0.8;
            sum += x * 2;
            g += 2;
        }
        Console.WriteLine($"Year 90t: {g}");
    }
}

