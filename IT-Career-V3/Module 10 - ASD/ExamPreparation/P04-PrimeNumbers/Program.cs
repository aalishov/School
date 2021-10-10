using System;

namespace P04_PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int num = 2;

            while (counter < n)
            {                
                // flag variable to tell
                // if i is prime or not
                int flag = 1;

                for (int j = 2; j <= num / 2; ++j)
                {
                    if (num % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                // flag = 1 means i is prime
                // and flag = 0 means i is not prime
                if (flag == 1)
                {
                    Console.Write(num + " ");
                    counter++;
                }
                num++;
            }

        }
    }
}
