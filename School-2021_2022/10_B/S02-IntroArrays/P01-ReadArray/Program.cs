using System;

namespace P01_ReadArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            //Въвеждаме елементи
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number [{i}]: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }



            //Извеждаме
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"numbers[{i}] => {numbers[i]}");
            }

        }
    }
}
