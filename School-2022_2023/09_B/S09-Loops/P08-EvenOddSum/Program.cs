using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int even = 0; int odd= 0;
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                even += int.Parse(Console.ReadLine());
            }
            else
            {
                odd += int.Parse(Console.ReadLine());
            }
        }
        if (even == odd)
        {
            Console.WriteLine($"Yes");
        }
        else
        {
            Console.WriteLine($"No");
        }
    }
}

