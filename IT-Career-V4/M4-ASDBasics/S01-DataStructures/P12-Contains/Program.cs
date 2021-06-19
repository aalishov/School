using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int num = int.Parse(Console.ReadLine());

        bool contain = false;

        for (int i = 0; i < nums.Length; i++)
        {
            if (num == nums[i])
            {
                contain = true;
                break;
            }
        }

        Console.WriteLine(contain ?
            $"{num} Exists in the List" :
            $"{num} Not exists in the List");
    }
}
