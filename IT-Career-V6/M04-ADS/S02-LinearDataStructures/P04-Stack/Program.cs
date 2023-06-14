using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        MyStack<int> nums = new MyStack<int>();
        Stack<int> nums2 = new Stack<int>();



        nums.Push(10);
        nums.Push(20);
        nums.Push(30);
        nums.Push(40);

        Console.WriteLine(string.Join(", ", nums.ToArray()));

    }
}

