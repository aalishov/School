using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> nums = new LinkedList<int>();
        nums.AddFirst(5);
        nums.AddLast(15);
        nums.AddLast(20);
        LinkedListNode<int> node = new LinkedListNode<int>(15);
        nums.AddBefore(node, 30);
        Console.WriteLine(string.Join(", ",nums));
    }
}

