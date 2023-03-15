using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Stack<int> clothes = new Stack<int>(elements);
        int capacity = int.Parse(Console.ReadLine());
        int rackCount = 0 ;
        int sum = 0;
        while (clothes.Count>0)
        {
            int currentElement = clothes.Pop();
            if (sum+currentElement<capacity)
            {
                sum += currentElement;
            }
            else if (sum+currentElement==capacity)
            {
                rackCount++;
                sum = 0;
            }
            else if (sum+currentElement>capacity)
            {
                rackCount++;
                sum = currentElement;
            }
        }
        if (rackCount==0)
        {
            Console.WriteLine(rackCount);
        }
        else
        {
            Console.WriteLine(rackCount + 1);
        }
        
    }
}

