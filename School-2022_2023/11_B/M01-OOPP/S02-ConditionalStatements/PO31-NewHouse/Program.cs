
using System;

public class Program
{
    static void Main()
    {
        string flowers = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());
        double price = 0;
        switch (flowers)
        {
            case "Roses":
                price = 5;
                if (count>80)
                {
                    price *= 0.9;
                }
                break;
            case "Dahlias":
                price = 3.80;
                if (count>90)
                {
                    price *= 0.85;
                }
                break;
            case "Tulips":
                if (count>80)
                {
                    price *= 0.85;
                }
                price = 2.80;
                break;
            case "Narcissus":
                price = 3;
                if (count<120)
                {
                    price *= 1.15;
                }
                break;
            case "Gladiolus":
                price = 2.50;
                if (count<80)
                {
                    price *= 1.2;
                }
                break;
        }
        double totalPrice = count * price;
        if (totalPrice <= budget)
        {
            Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {budget - totalPrice:F2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money, you need {totalPrice - budget:F2} leva more.");
        }                
    }
}

