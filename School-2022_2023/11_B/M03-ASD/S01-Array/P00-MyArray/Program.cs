using System;


public class Program
{
    static void Main()
    {

        // int[] nums =MyArray.RandomArray(20,-50,50);
        // int[] nums2 = new int[] { 2, 3 ,-5, 21, 30};
        // Console.WriteLine(MyArray.Print(nums));
        // Console.WriteLine(MyArray.SumDevidedBy3AndBiggerThan15(nums));
        // Console.WriteLine(MyArray.SumDevidedBy3AndBiggerThan15(nums2));
        // Console.WriteLine(MyArray.Print(MyArray.ElementsDevidedBy3AndBiggerThan15(nums2)));

        //int[] array = MyArray.RandomArray(20,0,9);
        //int[] newArray = MyArray.AddUpTo10(array);
        //Console.WriteLine(MyArray.Print(array));
        //Console.WriteLine(MyArray.Print(newArray));

        int[] array1 = { 1, 5 };
        int[] array2 = { 10, -5, 0 };
        int num = 5;

        int[] result = MyArray.CombineArraysAndAddNum(array1, array2, num);
        Console.WriteLine(MyArray.Print(array1));
        Console.WriteLine(MyArray.Print(array2));
        Console.WriteLine(MyArray.Print(result));
    }
}

