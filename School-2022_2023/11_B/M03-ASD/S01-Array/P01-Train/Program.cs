using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] wagons = new int[n];
        SetItemsValue(wagons);
        PrintItems(wagons);
        Console.WriteLine(Sum(wagons));
        Console.WriteLine(Multiply(wagons)); 

    }
    private static int Multiply(int[] wagons)
    {
        int multiply = 1;
        for (int i = 0; i < wagons.Length; i++)
        {
            if (wagons[i]!=0)
            {
                multiply *= wagons[i];
            }
        }
        return multiply;
    }
    private static int Sum(int[] wagons)
    {
        int sum = 0;
        for (int i = 0; i < wagons.Length; i++)
        {
            sum += wagons[i];
        }
        return sum;
    }

    private static void PrintItems(int[] wagons)
    {
        for (int i = 0; i < wagons.Length; i++)
        {
            Console.Write(wagons[i] + " ");
        }
        Console.WriteLine();
    }

    private static void SetItemsValue(int[] wagons)
    {
        for (int i = 0; i < wagons.Length; i++)
        {
            int people = int.Parse(Console.ReadLine());
            wagons[i] = people;
        }
    }
}

