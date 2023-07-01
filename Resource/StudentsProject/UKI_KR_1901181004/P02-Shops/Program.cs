using System;

public class Program
{
    static void Main()
    {

        string product = Console.ReadLine();
        string town = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());
        double price = 0.0;
        if (town == "Sofia")
        {
            if (product == "coffee") { price = 0.5; }
            else if (product == "water") { price = 0.8; }
            else if (product == "sweets") { price = 1.45; }
            else if (product == "peanuts") { price = 1.6; }
        }
        else if (town == "Plovdiv")
        {
            if (product == "coffee") { price = 0.4; }
            else if (product == "water") { price = 0.7; }
            else if (product == "sweets") { price = 1.3; }
            else if (product == "peanuts") { price = 1.5; }
        }

        double total = price * quantity;
        Console.WriteLine(total);
    }
}

