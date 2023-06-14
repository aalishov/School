using System;
using System.Collections.Generic;

public class Program
{
    //FIFO
    static void Main()
    {
        MyQueue<int> queue = new MyQueue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        Console.WriteLine(string.Join(", ",queue.ToArray()));

        //Count
        //Enqueue
        //Dequeue
        //Peek
        //Clear
        //ToArray
        //Contains
        //Foreach

    }
}

