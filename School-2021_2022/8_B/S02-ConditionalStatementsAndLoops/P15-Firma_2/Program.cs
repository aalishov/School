using System;
class Program
{
    static void Main()
    {
        double x = 130;
        int g = 2010;
        do
        {
            x *= 0.9;
            g++;
        } while (x >= 10);
        Console.WriteLine($"Year: {g}");
    }
}

