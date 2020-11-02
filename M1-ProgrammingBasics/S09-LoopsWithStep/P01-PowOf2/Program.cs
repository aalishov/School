using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 1;

        Console.WriteLine(num);

        int i = 0;
        while (true)
        {
            Console.WriteLine(num *= 2);
            i++;
        }

        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(num*=2);
        //}

    }
}

