using System;

namespace UKI_DR1_1901181004
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Въведи размерност на масивите: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Въвеждане на елементи на първи масив: ");
            int[] arr1 = ReadArray(m);
            Console.WriteLine("Въвеждане на елементи на втори масив: ");
            int[] arr2 = ReadArray(m);

            int max = int.MinValue;
            int min = int.MaxValue;
            int[] arr3 = new int[m];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arr1[i] * arr2[i];
                if (arr3[i] > max) { max = arr3[i]; }
                if (arr3[i] < min) { min = arr3[i]; }
            }

            Console.WriteLine($"Масив 3: {string.Join(", ",arr3)}");
            Console.WriteLine($"Най-малък елемент: {min}");
            Console.WriteLine($"Най-голям елемент: {max}");

        }

        public static int[] ReadArray(int length)
        {
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Въведи стойност на елемент: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
    }
}
