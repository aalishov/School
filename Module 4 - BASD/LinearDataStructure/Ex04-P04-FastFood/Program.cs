using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04_P04_FastFood
{
    public class Program
    {
        static void Main()
        {
            int food = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(ReadNumsArr());

            int biggest = orders.Max();

            while (orders.Any())
            {
                if (food-orders.Peek()>0)
                {
                    food -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(biggest);
            if (orders.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(", ",orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }

        private static int[] ReadNumsArr()
        {
            return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }
}
