using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine(arr[5]);
        Console.WriteLine(arr.Length);
    }
    public int GetSumEven(int[] array)
    {
        int sum = 0; //1
        for (int i = 0; i < array.Length; i++) //10
        {
            if (array[i] % 2 == 1) //10
            {
                sum += array[i];  //10
            }
        }
        return sum;
    }
}
public class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public byte Age { get; set; }

    public List<byte> Grades { get; set; } = new List<byte>();
}