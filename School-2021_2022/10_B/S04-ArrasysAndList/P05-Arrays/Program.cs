using System;

namespace P05_Arrays
{
    class Program
    {
        static void Main()
        {
            int n = ReadArrLength();
            double[] numbers = new double[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            Average(k,numbers);
        }
        static void Average(int k, double[] arr)
        {
            double sum = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                double element = arr[i];
                if (element % 5 == 0 && element <= k &&element>=(k*-1))
                {
                    sum += element;
                    count++;
                }
            }
            Console.WriteLine($"Average: {sum/(double)count}");
        }

        static int ReadArrLength()
        {
            while (true)
            {
                Console.Write("Enter array length: ");
                int n = int.Parse(Console.ReadLine());
                if (n >= 2 && n <= 30)
                {
                    return n;
                }
                Console.WriteLine("Error...Enter number between 2..30");
            }
        }
    }
}
