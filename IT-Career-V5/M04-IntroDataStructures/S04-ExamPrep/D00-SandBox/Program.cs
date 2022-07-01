using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> nums = new LinkedList<int>();

        nums.AddFirst(1);
        nums.AddLast(2);
        nums.AddLast(3);
        nums.AddLast(4);

        LinkedListNode<int> firstNode = nums.Find(1);
    }
}

