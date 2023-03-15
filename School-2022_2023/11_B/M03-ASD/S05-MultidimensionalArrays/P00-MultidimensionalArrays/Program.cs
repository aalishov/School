using System;

public class Program
{
    public static void Main()
    {
        int[,] nums = MyArray.RandomArray(3, 3, -20, 20);
        Console.WriteLine(MyArray.PrintArray(nums));
        Console.WriteLine(MyArray.Sum(nums));
        Console.WriteLine(MyArray.SumDiagonal(nums));
        Console.WriteLine(MyArray.AboveDiagonal(nums));
        Console.WriteLine(MyArray.MaxElement(nums));
        Console.WriteLine(MyArray.GetSecondLargestElement(nums));
    }
}

