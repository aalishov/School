using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        int[] arr = { 2, 3, 54, 121, 12, 8 };
        List<int> list = new List<int>() { 12, 2, 544 - 121, 12, 8 };
        HashSet<int> set = new HashSet<int>() { 5, 5, 12, 1, 2, 3 };
        MyList<int> myList = new MyList<int>() { 5, 5, 12, 1, 2, 3 };

        Console.WriteLine(Sum(arr));
        Console.WriteLine(Sum(list));
        Console.WriteLine(Sum(set));
        myList.Add(159);
        myList.PrintReversed();

    }
    public static int Sum(IEnumerable<int> item)
    {
        int sum = 0;
        foreach (var i in item)
        {
            sum += i;
        }
        return sum;
    }


    public class MyList<T> : List<T>
    {
        public void PrintReversed()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                Console.Write(this[i]+" ");
            }
            Console.WriteLine();
        }
    }
}

