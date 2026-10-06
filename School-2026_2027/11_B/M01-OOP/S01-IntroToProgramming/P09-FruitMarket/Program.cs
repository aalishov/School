
using System;
public class Program
{
    public static void Main()
    {
        double sPrice = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double o = double.Parse(Console.ReadLine());
        double r = double.Parse(Console.ReadLine());
        double s = double.Parse(Console.ReadLine());

        double priceR = sPrice / 2;
        double priceO = priceR - (priceR * 0.4);
        double priceB = priceR - (priceR * 0.8);

        double totalPrice = (b * priceB) + (o * priceO) + (r * priceR) + (s * sPrice);
        Console.WriteLine(totalPrice);
    }
}

