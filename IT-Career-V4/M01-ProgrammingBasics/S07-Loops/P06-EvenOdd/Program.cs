using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int evenSum = 0;
        int oddSum = 0;

        //Вариант 1
        //for (int i = 0; i < n; i++)
        //{
        //    int num = int.Parse(Console.ReadLine());
        //    if (i % 2 == 0)
        //    {
        //        evenSum += num;
        //    }
        //    else
        //    {
        //        oddSum += num;
        //    }
        //}

        //Вариант 2
        //for (int i = 0; i < n / 2; i++)
        //{
        //    int num1 = int.Parse(Console.ReadLine());
        //    int num2 = int.Parse(Console.ReadLine());

        //    evenSum += num1;
        //    oddSum += num2;
        //}

        //Вариант 3
        for (int i = 0; i < n; i+=2)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            evenSum += num1;
            oddSum += num2;
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {evenSum}");
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
        }
    }
}

