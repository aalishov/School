using System;

namespace P00_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStrangeCollection<int> nums= new MyStrangeCollection<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);
            nums.Add(6);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
