using System;


class Program
{
    static void Main()
    {
        const double eur = 1.94;

        double vegetablePrice = double.Parse(Console.ReadLine());
        double fruitsPrice = double.Parse(Console.ReadLine());
        int vegetableKg = int.Parse(Console.ReadLine());
        int fruitskg = int.Parse(Console.ReadLine());

        double totalPrice = (vegetableKg * vegetablePrice) + (fruitskg * fruitsPrice);

        double totalPriceEur = totalPrice / eur;

        Console.WriteLine($"{totalPriceEur}");
    }
}

