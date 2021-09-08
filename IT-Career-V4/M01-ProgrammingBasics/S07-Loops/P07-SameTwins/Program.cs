using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int lastSum = 0;
        int maxDiff = 0;
        bool isDifferent = false;

        for (int i = 0; i < n; i++)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int currentSum = num1 + num2;
            int currentDiff = 0;

            if (i==0)
            {
                sum = currentSum;
                lastSum = currentSum;
            }
            else if (sum!=currentSum)
            {
                isDifferent = true;
            }
            currentDiff = Math.Abs(lastSum - currentSum);

            lastSum = currentSum;
            if (currentDiff>maxDiff)
            {
                maxDiff = currentDiff;
            }
        }


        if (isDifferent)
        {
            Console.WriteLine($"No, maxdiff={maxDiff}");
        }
        else
        {
            Console.WriteLine($"Yes, value={sum}");
        }
    }
}

