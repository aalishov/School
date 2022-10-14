using System;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = n; i >= 0; i--)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(i*num);
        }
    }
}

