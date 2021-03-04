using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        //Подточка а)
        int[] arr = RandomArray(70, 0, 200);
        Console.WriteLine(string.Join(", ", arr.Where(x => x != 0)));

        //Подточка б)
        //int[] readArr = ReadArray(10);
        //ProductFilter(readArr, 10, 20);
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());
        int result = RandomNumberSum(a) + RandomNumberSum(b * c);
        Console.WriteLine(result);
    }
    //Решение на подточка в)
    public static int RandomNumberSum(int k)
    {
        int[] arr = RandomArray(k, -300, 300);
        int totalSum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                int sum = arr[i] + arr[j];
                if (i != j && sum % 2 == 0)
                {
                    totalSum += sum;
                }
            }
        }
        return totalSum;
    }

    //Решение на подточка б)
    public static void ProductFilter(int[] array, int minElement, int maxElement)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                int product = array[i] * array[j];
                if (i != j && product >= minElement && product <= maxElement)
                {
                    Console.WriteLine($"{array[i]}*{array[j]}={product}");
                }
            }
        }
    }

    public static int[] ReadArray(int length)
    {
        int[] arr = new int[length];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter number [{i + 1}]: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }

    //Решение на подточка а)
    public static int[] RandomArray(int length, int minElement, int maxElement)
    {
        int[] arr = new int[length];
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(minElement, maxElement);
        }
        return arr;
    }
}

