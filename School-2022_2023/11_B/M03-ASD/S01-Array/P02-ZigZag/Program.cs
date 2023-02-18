using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];
        int index = 0;
        for (int i = 0; i < n/2; i++)
        {
            int[] nums1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] nums2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            firstArray[index] = nums1[0];
            secondArray[index] = nums1[1];
            index++;
            firstArray[index] = nums2[1];
            secondArray[index] = nums2[0];
            index++;
        }

        Console.WriteLine(string.Join(", ", firstArray));
        Console.WriteLine(string.Join(", ", secondArray));
    }
}

