using System;
using System.Linq;

public class Program
{
    public static void Main()
    {                                           //4 3 7
        int[] array= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n=int.Parse(Console.ReadLine());//4
     
        for (int i = 0; i < n; i++)
        {
          int firstItem = array[0];

            for (int j = 0; j < array.Length-1; j++)
            {
                array[j] = array[j + 1];
            }
            array[array.Length-1] = firstItem;
            
        }
        Console.WriteLine(String.Join(", ", array));

    }
}

