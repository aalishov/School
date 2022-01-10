using System;
using System.Collections.Generic;

namespace P00_SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 15, 12, 10 };
            List<int> list = new List<int>() { 15, 12, 10 };
            HashSet<int> set = new HashSet<int>() { 15, 15, 10 };
            Console.WriteLine(Sum(arr));
            Console.WriteLine(Sum(list));
        }
        public static int Sum(ICollection<int> arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }
}
