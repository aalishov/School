using System;

namespace P01_Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            bool isDay = Console.ReadLine() == "day" ? true : false;

            double price = 0;
            if (km < 20)
            {
                price = 0.70;
                if (isDay)
                {
                    price += km * 0.79;
                }
                else
                {
                    price += km * 0.90;
                }
            }
            else if (km >= 20 && km < 100)
            {
                price = km * 0.09;
            }
            else
            {
                price = km * 0.06;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
