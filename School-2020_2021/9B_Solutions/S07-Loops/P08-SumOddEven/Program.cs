using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int evenSum = 0;
        int oddSum = 0;

        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (i%2==0)
            {
                evenSum += num;
            }
            else
            {
                oddSum += num;
            }
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine($"Yes = {evenSum}");
        }
        else
        {
            Console.WriteLine($"No, diff={Math.Abs(evenSum - oddSum)}");
        }
    }
}

