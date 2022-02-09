using System;
using System.Linq;

namespace P00_CreateArrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Random random = new Random();

            //int[] numbers = new int[20];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = random.Next(-20,20);
            //}
            //int length = -1;
            //string[] words = new string[3];
            //words[0] = "Delete";
            //words[words.Length-1] = "Insert";
            //words[1] = "Copy";
            //words[3] = "Print";//Exception

            //string[] names = Console.ReadLine()
            //    .Split(' ')
            //    .ToArray();

            double[] temperature = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .Select(x=>x+1)
                .ToArray();

            string[] months = new string[] { "January,May" };

            Console.WriteLine($"{string.Join(", ",temperature)}");
            Console.WriteLine($"{string.Join(", ", months)}");
        }
    }
}
