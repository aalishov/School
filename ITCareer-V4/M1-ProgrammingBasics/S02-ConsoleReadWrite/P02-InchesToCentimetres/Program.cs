using System;


class Program
{
    static void Main()
    {
        Console.Write("Inches = ");
        double inches = double.Parse(Console.ReadLine());
        double centimetres = inches * 2.54;
        Console.WriteLine($"Centimetres = {centimetres}");
    }
}

