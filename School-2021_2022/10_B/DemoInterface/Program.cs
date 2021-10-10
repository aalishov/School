using System;
using System.Collections.Generic;

namespace DemoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr1 = new double[] { 15, 26, 18 };
            List<double> list1 = new List<double>() { 8, 23, 21 };
            HashSet<double> hash1 = new HashSet<double>() { 8, 23, 12 };
            Console.WriteLine(Sum(arr1));
            Console.WriteLine(Sum(list1));
            Console.WriteLine(Sum(hash1));
        }

        static double Sum(ICollection<double> arr)
        {
            double sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }
            return sum;
        }

    }
}
