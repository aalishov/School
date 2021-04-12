using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> numbers = new Stack<int>();
        numbers.Push(1);
        numbers.Push(2);
        numbers.Push(3);
        numbers.Push(4);
        numbers.Push(5);
        numbers.Push(6);

        while (numbers.Count>0)
        {
            int num = numbers.Pop();
            Console.WriteLine(num);
            //6, 5, 4, 3, 2, 1
        }
    }
}

