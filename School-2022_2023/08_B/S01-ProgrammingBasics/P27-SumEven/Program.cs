using System;

public class Program
{
    public static void Main()
    {
        int sum = 0;

        Console.Write("Enter even number: ");
        int num = int.Parse(Console.ReadLine());

        while (num % 2 == 0)
        {
            sum += num;
            Console.Write("Enter even number: ");
            num = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Sum: {sum}");
    }
}

