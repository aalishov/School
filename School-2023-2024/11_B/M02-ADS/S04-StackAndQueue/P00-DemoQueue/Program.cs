public class Program
{
    public static void Main()
    {
        //FIFO
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);

        //Console.WriteLine(queue.Dequeue());

        Console.WriteLine($"Queue count: {queue.Count}");

        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}

