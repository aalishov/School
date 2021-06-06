using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> nums = new Stack<int>();
        nums.Push(1);
        nums.Push(2);
        nums.Push(3);
        nums.Push(4);
        Console.WriteLine(nums.Pop());
    }
}

