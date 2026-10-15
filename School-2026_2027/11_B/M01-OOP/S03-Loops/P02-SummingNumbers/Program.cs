using System;
namespace P02_SummingNumbers
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }

            Console.WriteLine(sum);


        }
    }
}
