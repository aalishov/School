using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int cmd = input[0];
            switch (cmd)
            {
                case 1:
                    int element = input[1];
                    stack.Push(element);
                    break;
                case 2: 
                    stack.Pop();
                    break;
                case 3:
                    Console.WriteLine(stack.Max());
                    break;
                case 4:
                    Console.WriteLine(stack.Min());
                    break;
            }
        }
        Console.WriteLine(string.Join(", ", stack));
    }
}

