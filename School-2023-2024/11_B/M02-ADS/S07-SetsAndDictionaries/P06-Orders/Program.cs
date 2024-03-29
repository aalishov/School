using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        Dictionary<string, (double price, int quantity)> products = new Dictionary<string, (double, int)>();

        string input;
        while ((input = Console.ReadLine()) != "buy")
        {
            string[] productInfo = input.Split();
            string productName = productInfo[0];
            double price = double.Parse(productInfo[1]);
            int quantity = int.Parse(productInfo[2]);

            if (products.ContainsKey(productName))
            {
                products[productName] = (price, products[productName].quantity + quantity);
            }
            else
            {
                products.Add(productName, (price, quantity));
            }
        }

        foreach (var product in products)
        {
            double totalPrice = product.Value.price * product.Value.quantity;
            Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
        }
    }
}