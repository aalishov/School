using System;
using System.Linq;

namespace P01_Train
{
    class Program
    {
        static void Main()
        {
            Console.Write("Wagons: ");
            int wagons = int.Parse(Console.ReadLine());

            int[] peoples = new int[wagons];

            for (int i = 0; i < peoples.Length; i++)
            {
                Console.Write($"Wagon {i+1}: ");
                peoples[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Wagons info: {string.Join(" | ",peoples)}");
            Console.WriteLine($"Peoples: {peoples.Sum()}");
        }
    }
}
