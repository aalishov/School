using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> nums = new Queue<int>();
        nums.Enqueue(15);
        nums.Enqueue(25);
        nums.Enqueue(35);

        Stack<int> nums2 = new Stack<int>();
        nums2.Push(15);
        nums2.Push(25);
        nums2.Push(35);
        Console.WriteLine($"Queue=> {string.Join(", ", nums)}");
        Console.WriteLine($"Stack=> {string.Join(", ", nums2)}");
    }
}

