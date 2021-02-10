using System;

namespace P03_EnergyBooster
{
    class Program
    {


        static void Main(string[] args)
        {
            //Четене на входни данни
            Console.Write("Fruit: ");
            string fruit = Console.ReadLine().ToLower();
            Console.Write("Set size: ");
            string setSize = Console.ReadLine().ToLower();
            Console.Write("Set numbers: ");
            int setNumbers = int.Parse(Console.ReadLine());

            decimal productPrice = 0.0m;
            decimal totalPrice = 0.0m;

            if (setSize == "small")
            {

                switch (fruit)
                {
                    case Watermelon:
                        productPrice = SmallWatermellon;
                        break;
                    case Mango:
                        productPrice = SmallMango;
                        break;
                    case Pineapple:
                        productPrice = SmallPineapple;
                        break;
                    case Rapberry:
                        productPrice = SmallRaspberry;
                        break;
                }
                totalPrice = SmallSet * productPrice;
            }
            else if(setSize=="big")
            {
                switch (fruit)
                {
                    case Watermelon:
                        productPrice = BigWatermellon;
                        break;
                    case Mango:
                        productPrice = BigMango;
                        break;
                    case Pineapple:
                        productPrice = BigPineapple;
                        break;
                    case Rapberry:
                        productPrice = BigRaspberry;
                        break;
                }
                totalPrice = BigSet * productPrice;
            }
            else
            {
                throw new ArgumentException("Invalid set!");
            }
            totalPrice *= setNumbers;
            if (totalPrice > 1000)
            {
                totalPrice *= 0.5m;
            }
            else if (totalPrice >= 400 && totalPrice <= 1000)
            {
                totalPrice *= 0.85m;
            }
            Console.WriteLine($"Total set price: {totalPrice:c2}");
        }

        const string Pineapple = "pineapple";
        const string Watermelon = "watermelon";
        const string Mango = "mango";
        const string Rapberry = "raspberry";
        const decimal SmallWatermellon = 56m;
        const decimal SmallMango = 36.66m;
        const decimal SmallPineapple = 42.1m;
        const decimal SmallRaspberry = 20m;
        const decimal BigWatermellon = 28.7m;
        const decimal BigMango = 19.6m;
        const decimal BigPineapple = 24.8m;
        const decimal BigRaspberry = 15.20m;
        const int BigSet = 5;
        const int SmallSet = 2;
    }
}
