using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int[]  input=Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            switch (input[0]) {
                case 1:
                    stack.Push(input[1]);
                    break;
                case 2:
                    if (stack.Any())
                    {
                        stack.Pop();
                    }
                    break;
                case 3:
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Max());
                    }
                    break;
                case 4:
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Min());
                    }
                    break;
            }
        }
        Console.WriteLine(string.Join(", ",stack));
    }
}

