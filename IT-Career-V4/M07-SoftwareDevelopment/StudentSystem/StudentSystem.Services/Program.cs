using System;
using System.Collections.Generic;

namespace StudentSystem.Services
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> nums = new HashSet<int> { 1, 2,2,2, 3, 4,3,3, 5, 6, };
            Console.WriteLine(String.Join(", ",nums));
        }
    }
}
