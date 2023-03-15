using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        int[] ints = { 1, 2, 3, 4, 5, };
        Stack<int> stack = new Stack<int>(ints);
        Queue<int> queue = new Queue<int>(ints);

        Console.WriteLine($"Stack => {string.Join(", ",stack)}");
        Console.WriteLine($"Queue => {string.Join(", ", queue)}");
    }
}

