using System;
using System.Collections.Generic;
using System.Linq;

namespace P00_SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>(new[] { 3, 5, 7, 12, 8, 7 });
            List<int> filter = new[] { 3, 7, 12, 8, }.Where(x => x % 2 == 0).ToList();
            int count = new[] { -30, 7, 50, 8}.Where(x => Math.Abs(x) > 30).Count();
            Console.WriteLine(count);
        }
    }
}
