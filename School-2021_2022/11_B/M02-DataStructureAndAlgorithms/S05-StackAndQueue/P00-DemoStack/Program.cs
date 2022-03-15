using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> q = new Stack<int>();
        q.Push(1);
        q.Push(2);
        q.Push(3);
        q.Push(4);
        Console.WriteLine(q.Peek());
    }
}

