using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] data = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = data[0];
        int m = data[1];

        Stack<int> nums = new Stack<int>();
        nums.Push(m);

        if (n <= m)
        {
            while (n != m)
            {
                if (m / 2 >= n && m % 2 == 0)
                {
                    nums.Push(m / 2);
                    m /= 2;
                }
                else if (m - 2 >= n)
                {
                    nums.Push(m - 2);
                    m -= 2;
                }
                else
                {
                    nums.Push(m - 1);
                    m -= 1;
                }
            }
            Console.WriteLine(string.Join(" --> ", nums.ToArray()));
        }
        else
        {
            Console.WriteLine($"Error: {n}>{m}");
        }
    }
}

