namespace P11_SmallShop
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double kolichestvo = double.Parse(Console.ReadLine());

            double price = default(double);

            if (city == "Sofia")
            {
                switch (product)
                {
                    case "coffee": price = 0.50; break;
                    case "water": price = 0.80; break;
                    case "juice": price = 1.20; break;
                    case "sweets": price = 1.45; break;
                    case "peanuts": price = 1.60; break;
                }
            }
            else if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee": price = 0.40; break;
                    case "water": price = 0.70; break;
                    case "juice": price = 1.15; break;
                    case "sweets": price = 1.30; break;
                    case "peanuts": price = 1.50; break;
                }

            }
            else if (city == "Varna")
            {
                switch (product)
                {
                    case "coffee": price = 0.45; break;
                    case "water": price = 0.70; break;
                    case "juice": price = 1.10; break;
                    case "sweets": price = 1.35; break;
                    case "peanuts": price = 1.55; break;
                }
            }
            double tottalPrice = kolichestvo * price;
            Console.WriteLine(tottalPrice);
        }
    }
}