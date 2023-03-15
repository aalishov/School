using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main()
    {
        int[] info = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Queue<int> queue = new Queue<int>(nums);

        int removeCount = info[1];

        for (int i = 0; i < removeCount; i++) { queue.Dequeue(); }
        if (queue.Contains(info[2]))    //4 1 666 //666 69 13 420
        {
            Console.WriteLine("true");
        }
        else
        {
            int min = int.MaxValue;
            while (queue.Count > 0)
            {
                int element = queue.Dequeue();
                if (element < min)
                {
                    min = element;
                }
            }
            Console.WriteLine(min);
        }


    }
}

