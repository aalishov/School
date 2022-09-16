using System;

public class Program
{
    static void Main()
    {
        string fruit = Console.ReadLine();
        string size = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());

        double price = 0.0;
        if (size == "big")
        {
            count *= 5;
            switch (fruit)
            {
                case "Watermelon":
                    price = 28.70;
                    break;
                case "Mango":
                    price = 19.6;
                    break;
                case "Pineapple":
                    price = 24.80;
                    break;
                case "Raspberry":
                    price = 15.20;
                    break;
            }
        }
        else
        {
            count *= 2;
            switch (fruit)
            {
                case "Watermelon":
                    price = 56;
                    break;
                case "Mango":
                    price = 36.66;
                    break;
                case "Pineapple":
                    price = 42.10;
                    break;
                case "Raspberry":
                    price = 20;
                    break;
            }
        }
        double total = count * price;
        if (total >= 400 && total <= 1000)
        {
            total *= 0.85;
        }
        else if (total > 1000)
        {
            total *= 0.5;
        }
        Console.WriteLine($"{total:f2} lv.");
    }
}

