using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        MyQueue<int> queue = new MyQueue<int>();
        queue.Enqueue(10);
        queue.Enqueue(-2);
        queue.Enqueue(19);
        queue.Enqueue(20);
        Console.WriteLine($"Queue=> {string.Join(", ", queue)}");


        Console.WriteLine(queue.Peek());
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Peek());
        Console.WriteLine(queue.Peek());
        Console.WriteLine(queue.Dequeue());

        Console.WriteLine($"Queue=> {string.Join(", ", queue)}");

        Console.WriteLine($"20 => {queue.Contains(20)}");
    }
}

