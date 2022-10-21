using System;

public class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        while (num > sum)
        {
            int newNum = int.Parse(Console.ReadLine());
            sum += newNum;
        }
        Console.WriteLine(sum);
    }
}
