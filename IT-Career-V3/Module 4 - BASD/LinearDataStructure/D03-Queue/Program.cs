namespace D03_Queue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };

            Queue<int> q = new Queue<int>(nums);
            q.Enqueue(10);
            Console.WriteLine(q.Peek());

            while (q.Any())
            {
                Console.WriteLine(q.Dequeue());
            }
        }
    }
}
