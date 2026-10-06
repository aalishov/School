using System;

public class Program
{
  
    public static void Main()
    {
        int donations = int.Parse(Console.ReadLine());
        int bakers = int.Parse(Console.ReadLine());
        int cakes = int.Parse(Console.ReadLine());
        int waffles = int.Parse(Console.ReadLine());
        int pancakes = int.Parse(Console.ReadLine());
        double total = (cakes * GlobalConstants.CakePrice + waffles * GlobalConstants.WafflePrice + pancakes * GlobalConstants.PancakePrice) * bakers * donations;
        total -= total / 8.0;
        Console.WriteLine($"{total}");


    }
}

