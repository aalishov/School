using System;


public class Program
{
    public static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        double food = double.Parse(Console.ReadLine());
        double totalCatFood = 0;
        double totalDogFood = 0;
        double cookies = 0;
        for (int i = 1; i <= days; i++)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            if (i % 3 == 0) { cookies += (catFood + dogFood) * 0.1; }
            totalCatFood += catFood;
            totalDogFood += dogFood;
        }
        double totalFood = totalDogFood + totalCatFood;
        Console.WriteLine($"Total eaten biscuits: {cookies:f0}gr.");
        Console.WriteLine($"{(totalFood / food) * 100:f2}% of the food has been eaten.");
        Console.WriteLine($"{(totalDogFood / totalFood) * 100:f2}% eaten from the dog.");
        Console.WriteLine($"{(totalCatFood / totalFood) * 100:f2}% eaten from the cat.");
    }
}

