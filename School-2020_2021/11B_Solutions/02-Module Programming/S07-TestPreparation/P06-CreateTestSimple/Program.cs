using System;
using System.Linq;

namespace P06_CreateTestSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 7, 2, 5, 0, 4, 9, 6, 11 };

            var num = nums.Where(x => x % 2 == 1).Last();
            var num1 = nums.Where(x => x / 2 == 0).Last();
            var num2 = nums.Where(x => x % 2 == 0).First();
            var num3 = nums.Where(x => x / 2 == 0).First();

            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}
