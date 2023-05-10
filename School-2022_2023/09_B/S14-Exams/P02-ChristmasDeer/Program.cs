using System;

public class Program
{
    public static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int food = int.Parse(Console.ReadLine());
        double food1Deer = double.Parse(Console.ReadLine());
        double food2Deer = double.Parse(Console.ReadLine());
        double food3Deer = double.Parse(Console.ReadLine());
        double neededFood = (food1Deer + food2Deer + food3Deer) * days;

        if (neededFood<=food)
        {
            double leftFood = neededFood - food;
            Console.WriteLine($"{Math.Abs(leftFood)} kilos of food left.");
        }
        else 
        {
            double moreFoodNeeded = food - neededFood;
            Console.WriteLine($"{Math.Ceiling(Math.Abs(moreFoodNeeded))} more kilos of food are needed.");
        }
    }
}