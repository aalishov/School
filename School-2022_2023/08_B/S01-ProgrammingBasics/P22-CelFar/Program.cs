using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine($"{"C",-6}{"F",-5}");

        for (double c = 36; c <= 38; c += 0.1)
        {
            double f = (9.0 / 5.0) * c + 32;
            Console.WriteLine($"{c:f1}  {f:f1}");
        }
    }
}

