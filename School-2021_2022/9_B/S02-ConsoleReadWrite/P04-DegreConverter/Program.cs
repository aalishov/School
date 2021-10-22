using System;

class Program
{
    static void Main()
    {
        double rad = double.Parse(Console.ReadLine());
        double deg = rad* 57.2957795;
        Console.WriteLine(Math.Round(deg,0));
    }
}

