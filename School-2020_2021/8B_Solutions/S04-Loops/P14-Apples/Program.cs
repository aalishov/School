using System;


class Program
{
    static void Main()
    {
        //A)
        int yearA = 1990;
        double productsA = 20;

        while (productsA>=5)
        {
            Console.WriteLine($"Year: {yearA} products: {productsA}");
            yearA += 2;
            productsA *= 0.8;
        }
        Console.WriteLine($"Year under 5 tones: {yearA}");

        //B)
        int yearB = 1990;
        double productsB = 20;
        double sum = 0;

        while (sum<=90)
        {
            sum += (productsB * 2);
            yearB += 2;
            productsB *= 0.8;
            Console.WriteLine($"Year: {yearB} apples {sum} tones!");
        }
        Console.WriteLine($"Year over 90 tones: {yearB}");
    }
}

