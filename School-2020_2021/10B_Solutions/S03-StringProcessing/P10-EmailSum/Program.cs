using System;
namespace _0._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] element = Console.ReadLine().Split('@');
            int left = 0;
            int right = 0;
            for (int i = 0; i < element[0].Length; i++)
            {
                left += element[0][i];
            }
            Console.WriteLine(left);
            for (int i = 0; i < element[1].Length; i++)
            {
                right += element[1][i];
            }
            Console.WriteLine(right);
            if ((left - right) >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}