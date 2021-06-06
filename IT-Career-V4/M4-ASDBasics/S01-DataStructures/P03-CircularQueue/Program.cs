namespace P03_CircularQueue
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            // Циркулярна опашка (FIFO or LILO)
            var queue = new CircularQueue<int>();

            // Добавяме
            var items = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (var item in items)
            {
                queue.Enqueue(item);
            }

            // Печат
            while (queue.Count > 0)
            {
                Console.Write("{0} ", queue.Dequeue());
            }
        }
    }
}
