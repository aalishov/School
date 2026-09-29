using System;

public class Program
{
    public static void Main()
    {
        int dogs = Convert.ToInt32(Console.ReadLine());
        int animals = int.Parse(Console.ReadLine());

        double priceDogsFood = dogs * 2.5;
        double priceAnimalsLastFood = animals * 4.0;
        double totalPrice = priceDogsFood + priceAnimalsLastFood;
        Console.WriteLine($"{totalPrice} lv.");
    }
}

