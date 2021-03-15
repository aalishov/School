using System;

class Program
{
    static void Main()
    {
        bool isZero = false;
        int sum = 0;
        while (!isZero)
        {
            int n = int.Parse(Console.ReadLine());
            sum += n;
            if (n==0)
            {
                isZero = true;
            }
        }
        Console.WriteLine(sum);
    }
}

