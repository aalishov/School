using System;
using System.Threading.Tasks.Dataflow;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("$ ");
            }
            Console.WriteLine();
        }
    }
}

