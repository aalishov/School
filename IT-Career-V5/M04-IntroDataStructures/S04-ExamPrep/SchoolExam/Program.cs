using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };


        Console.WriteLine(String.Join(", ",nums.GetRange(2,13)));
    }
}
