using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        //var items = new Queue<int>(); //FIFO
        //items.Enqueue(5);
        //items.Enqueue(15);
        //items.Enqueue(25);
        //int number = items.Dequeue();//15, 25
        //int number2 = items.Peek(); //15, 25

        var items = new Stack<int>(); //LIFO
        items.Push(5);
        items.Push(15);
        items.Push(25);
        int number = items.Pop();
        int number2 = items.Pop();
        int number3 = items.Peek();
    }
}

