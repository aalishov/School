using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //int[] nums = new int[] { 1, 2, 3, 5, 6, 7 };
        Array.Sort(nums);
        Console.WriteLine(string.Join(", ", nums));

        int n = int.Parse(Console.ReadLine());
        int index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= n)
            {
                index = i;
                break;
            }
        }

        int[] newArr = new int[nums.Length + 1];

        Console.WriteLine(index);

        int counter = 0;

        // Вариант 1
        //for (int i = 0; i < newArr.Length; i++)
        //{
        //    if (i == index)
        //    {
        //        newArr[i] = n;
        //    }
        //    else
        //    {
        //        newArr[i] = nums[counter];
        //        counter++;
        //    }
        //}

        // Вариант 2
        for (int i = 0; i < index; i++)
        {
            newArr[i] = nums[i];
        }
        newArr[index] = n;
        for (int i = index+1; i < newArr.Length; i++)
        {
            newArr[i] = nums[i-1];
        }

        Console.WriteLine(string.Join(", ", newArr));
    }
}


