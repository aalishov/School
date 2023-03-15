using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var stack = new Stack<int>();
        stack.Push(10);
        stack.Push(-2);
        stack.Push(19);
        stack.Push(20);

        Console.WriteLine($"Stack=> {string.Join(", ", stack)}");

        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());

        Console.WriteLine($"Stack=> {string.Join(", ", stack)}");
        Console.WriteLine($"20 => {stack.Contains(20)}");
    }
}

