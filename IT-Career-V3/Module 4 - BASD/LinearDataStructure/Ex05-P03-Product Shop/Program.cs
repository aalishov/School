using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex05_P03_Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Product>> shops = new Dictionary<string, List<Product>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Revision")
                {
                    break;
                }

                string[] info = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shopName = info[0];
                string productName = info[1];
                double productPrice = double.Parse(info[2]);

                Product product = new Product(productName, productPrice);

                if (shops.ContainsKey(shopName))
                {
                    shops[shopName].Add(product);
                }
                else
                {
                    shops.Add(shopName, new List<Product> { product });
                }
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }
    }
}
