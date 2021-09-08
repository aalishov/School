using System;

namespace P05_ReversedList
{
    class Program
    {
        static void Main()
        {
            ReversedList<int> nums = new ReversedList<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);

            Console.WriteLine(string.Join(", ",nums));
        }
    }
}
