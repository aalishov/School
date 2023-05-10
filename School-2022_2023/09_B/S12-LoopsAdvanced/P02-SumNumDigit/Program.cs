using System;

public class Program
{
    public static void Main()
    {
        int num= int.Parse(Console.ReadLine());
        int sum = 0;
        do
        {
            sum += num % 10;
            num /= 10;
        } while (num!=0);
        Console.WriteLine(sum);
    }
}

