namespace D02_HashSet
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            //HashSet - пази уникални (няма повторения) стойности
            HashSet<int> nums = new HashSet<int>();

            Random random = new Random();

            while (nums.Count < 15)
            {
                nums.Add(random.Next(0, 60));
            }
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
