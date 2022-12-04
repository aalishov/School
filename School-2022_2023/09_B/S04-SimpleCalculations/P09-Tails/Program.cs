using System;
public class Program
{
    public static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double w = double.Parse(Console.ReadLine());
        double l = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double o = double.Parse(Console.ReadLine());

        double area = n * n;
        double tailArea = w * l;
        double benchArea = m * o;

        area -= benchArea; // == area=area-benchArea;
        double countTail = area / tailArea;
        double minutes = countTail * 0.2;

        Console.WriteLine($"{countTail:f2}");
        Console.WriteLine($"{minutes:f2}");
    }
}