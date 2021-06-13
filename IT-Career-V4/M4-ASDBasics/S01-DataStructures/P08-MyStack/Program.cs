using System;

public class Program
{
    public static void Main()
    {
        MyStack<int> stack = new MyStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        Console.WriteLine(string.Join(", ",stack.ToArray()));
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Contains(10));
        Console.WriteLine(stack.Contains(2));
    }
}

