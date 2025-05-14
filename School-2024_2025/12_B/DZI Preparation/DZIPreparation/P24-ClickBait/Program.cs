using System;
public class Program
{
    public static void Main()
    {
        int[] queue = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        Queue<int> recommended = new Queue<int>(queue);
        int[] stack = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        Stack<int> featured = new Stack<int>(stack);
        int target = int.Parse(Console.ReadLine());
        List<int> result = new List<int>();

        while (recommended.Any() && featured.Any())
        {
            int a = recommended.Dequeue();
            int b = featured.Pop();
            int remain = 0;
            if (a > b)
            {
                remain = a % b;
                result.Add(Math.Abs(remain)*-1); 
                if (remain != 0)
                {
                    remain *= 2;
                    recommended.Enqueue(remain);
                }
            }
            else if (a==b)
            {
                result.Add(0);
            }
            else
            {
                remain = b % a;
                result.Add(Math.Abs(remain));
                if (remain > 0)
                {
                    remain *= 2;
                    featured.Push(remain);
                }
            }
        }
        int total = result.Sum();
        Console.WriteLine($"Final Feed: {string.Join(", ", result)}");
        if (total >= target)
        {
            Console.WriteLine($"Goal achieved! Engagement Value: {total}");
        }
        else
        {
            Console.WriteLine($"Goal not achieved! Short by: {target-total}");
        }
    }
}

