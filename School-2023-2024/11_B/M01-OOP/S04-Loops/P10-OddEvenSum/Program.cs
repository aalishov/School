namespace P10_OddEvenSum
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    oddSum += num;
                }
                else
                {
                    evenSum += num;
                }
            }
            if (oddSum == evenSum)
            {
                Console.Write("Yes");
                //Console.WriteLine($"Sum = {oddSum}");

            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
            }

        }
    }
}