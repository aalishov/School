using System;

public class Program
{
    public static void Main()
    {
        int paper = int.Parse(Console.ReadLine());
        int cloth = int.Parse(Console.ReadLine());
        double glue = double.Parse(Console.ReadLine());
        int discount = int.Parse(Console.ReadLine());

        double paperPrice = 5.80 * paper;
        double clothPrice = 7.20 * cloth;
        double gluePrice = 1.20 * glue;

        double sumPrice = paperPrice + clothPrice + gluePrice;
        double finalPrice = sumPrice - (sumPrice *(discount / 100.0));

        Console.WriteLine($"{finalPrice:F3}");


    }
}

