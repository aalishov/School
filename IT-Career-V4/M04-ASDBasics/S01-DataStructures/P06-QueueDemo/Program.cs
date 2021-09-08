using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> num = new Queue<int>();
        num.Enqueue(1);
        num.Enqueue(2);
        num.Enqueue(3);
        num.Enqueue(4);

        while (num.Any())
        {
            Console.WriteLine(num.Dequeue());
        }
    }
}

