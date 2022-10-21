using System;

public class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int n = 1;
        while (n <= number)
        {
            Console.WriteLine(n);
            n = 2 * n + 1;
        }
    }
}
