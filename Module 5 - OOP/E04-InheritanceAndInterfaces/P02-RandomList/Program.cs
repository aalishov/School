using System;
using System.Linq;
using System.Collections.Generic;

namespace P02_RandomList
{
    public class Program
    {
        public static void Main()
        {
            RandomList<int> nums = new RandomList<int>();
            nums.Add(2);
            nums.Add(5);
            nums.Add(12);
            Console.WriteLine(nums.RandomString());
        }
    }
}
