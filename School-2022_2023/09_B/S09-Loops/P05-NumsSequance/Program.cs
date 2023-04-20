using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 1;
        while (num < n)
        {
            Console.WriteLine(num);
            num = num * 2 + 1;
        }
    }
}

