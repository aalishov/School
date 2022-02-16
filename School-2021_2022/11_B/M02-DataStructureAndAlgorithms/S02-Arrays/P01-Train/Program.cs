using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int[] wagons = new int[count];

        for (int i = 0; i < wagons.Length; i++)
        {
            wagons[i] = int.Parse(Console.ReadLine());
        }
        int peopleCount = 0;
        for (int i = 0; i < wagons.Length; i++)
        {
            peopleCount += wagons[i];
            Console.Write($"{wagons[i]} ");
        }
        // Console.WriteLine($"{string.Join(" ",wagons)}");
        Console.WriteLine();
        Console.WriteLine(peopleCount);
        //Console.WriteLine(wagons.Sum());
    }
}

