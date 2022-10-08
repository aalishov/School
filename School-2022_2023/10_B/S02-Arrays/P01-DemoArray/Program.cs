using System;

public class Program
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int n=int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        //Print
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"{i} => {numbers[i]}");
        }
        //Console.WriteLine(String.Join(", ",numbers));
    }
}

