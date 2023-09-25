namespace P08_ZooShop
{
    using System;
    public class Program
    {
        const double DogFoodPrice = 2.5;
        const double FoodPrice = 4;

        public static void Main()
        {
            int nDogs = int.Parse(Console.ReadLine());
            int nRest = int.Parse(Console.ReadLine());
            double fTotal = DogFoodPrice * nDogs + nRest * FoodPrice;
            Console.WriteLine($"{fTotal} lv");
        }
    }
}