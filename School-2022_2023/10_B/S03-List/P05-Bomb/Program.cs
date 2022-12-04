using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        List<int> bombInfo = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        int bomb = bombInfo[0];
        int power = bombInfo[1];

        while (nums.Any(x => x == bomb))
        {
            int bombIndex = nums.FindIndex(x => x == bomb);
            for (int i = 0; i < power; i++)
            {
                if (bombIndex + 1 < nums.Count)
                {
                    nums.RemoveAt(bombIndex + 1);
                }
            }
            for (int i = 0; i < power; i++)
            {
                if (bombIndex - 1 >= 0)
                {
                    nums.RemoveAt(bombIndex - 1);
                    bombIndex--;
                }
            }
            nums.RemoveAt(bombIndex);
        }
        //Console.WriteLine(String.Join(", ", nums));
        Console.WriteLine(nums.Sum());

        
    }
}
