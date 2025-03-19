

using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        Queue<int> queue = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
        for (int i = 0; i < nums[1]; i++)
        {
            queue.Dequeue();

        }
        if (queue.Contains(nums[2]))
        {
            Console.WriteLine(true);
        }
        else
        {
            if (queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }

    }
}

