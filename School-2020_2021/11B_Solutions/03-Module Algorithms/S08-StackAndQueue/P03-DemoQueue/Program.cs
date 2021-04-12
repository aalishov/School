using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> numbers = new Queue<int>();
        numbers.Enqueue(1);
        numbers.Enqueue(2);
        numbers.Enqueue(3);
        numbers.Enqueue(4);
        numbers.Enqueue(5);
        numbers.Enqueue(6);

        while (numbers.Count > 0)
        {
            int num = numbers.Dequeue();
            Console.WriteLine(num);
            //1, 2, 3, 4, 5, 6  
        }
    }
}

