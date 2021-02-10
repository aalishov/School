using System;


class Program
{
    static void Main(string[] args)
    {
        const double timePerTile= 0.2;

        //Страна на площадка
        double n = double.Parse(Console.ReadLine());
        //Страни на плочка
        double w = double.Parse(Console.ReadLine());
        double l = double.Parse(Console.ReadLine());
        //Страни на пейка
        double m = double.Parse(Console.ReadLine());
        double o = double.Parse(Console.ReadLine());

        double area = (n * n)-(m*o);

        double tileArea = w * l;

        double neededTiles = area / tileArea;

        double neededTime = neededTiles * timePerTile;

        Console.WriteLine($"{neededTiles:f2}");
        Console.WriteLine($"{neededTime:f2}");
    }
}

