using System;

public class Program
{
    static void Main()
    {
        string product = Console.ReadLine();
        string town = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());

        double price = 0.0;
        if (town == "Sofia")
        {
            switch (product)
            {
                case "coffee":
                    price = 0.50;
                    break;
                case "water":
                    price = 0.80;
                    break;
                case "juice":
                    price = 1.20;
                    break;
                case "sweets":
                    price = 1.45;
                    break;
                case "peanuts":
                    price = 1.60;
                    break;
            }
        }
        else if (town == "Varna")
        {
            switch (product)
            {
                case "coffee":
                    price = 0.45;
                    break;
                case "water":
                    price = 0.70;
                    break;
                case "juice":
                    price = 1.10;
                    break;
                case "sweets":
                    price = 1.35;
                    break;
                case "peanuts":
                    price = 1.55;
                    break;
            }
        }
        else
        {
            switch (product)
            {
                case "coffee":
                    price = 0.40;
                    break;
                case "water":
                    price = 0.70;
                    break;
                case "juice":
                    price = 1.15;
                    break;
                case "sweets":
                    price = 1.30;
                    break;
                case "peanuts":
                    price = 1.50;
                    break;
            }
        }
        Console.WriteLine(price * count);
    }
}

