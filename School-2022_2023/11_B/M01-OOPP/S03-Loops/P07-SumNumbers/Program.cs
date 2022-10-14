using System;


public class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int count=int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            int num = int.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine(sum);
    }
}

