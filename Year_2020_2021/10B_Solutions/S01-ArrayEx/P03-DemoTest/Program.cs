using System;
using System.Linq;

namespace P03_DemoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 12, 12, 3, 4, 12, 4, 45, -12, -7, -7 };
            // int[] nums = new int[] { 12, 2 };

            Console.WriteLine($"Length: {nums.Length}");
            Console.WriteLine($"Distinct: {string.Join(", ",nums.Distinct())}");

            var nums1 = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            int[] train = new int[] { 2, 3, 5 };
            int[] train2 = new int[] { 2, 3, 5 };

            var isEqual = train[0] != train[1];
        }
    }
}
