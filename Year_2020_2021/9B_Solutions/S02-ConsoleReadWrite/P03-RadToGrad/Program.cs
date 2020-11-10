using System;


class Program
{
    static void Main()
    {
        double rad = double.Parse(Console.ReadLine());
        double gradus = rad * 180 / Math.PI;
        //Console.WriteLine($"{gradus:f0}");
        Console.WriteLine(Math.Round(gradus,0));
    }
}