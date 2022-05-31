using System;
class Problem25
{
    static int[] readArray()
    {
        Console.WriteLine("Въведете брой елементи");
        int n;
        do
        {
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 1)
                Console.WriteLine("Моля, въведете положително число!");
        } while (n < 1);
        int[] result = new int[n];
        for (int i = 0; i < n; i++)
        {
            do
            {
                Console.WriteLine("Моля, въведете елемент " + (i +
               1));
                result[i] = Convert.ToInt32(Console.ReadLine());
                if (result[i] < 1)
                    Console.WriteLine("Моля, въведете положително  число!");
            } while (result[i] < 1);
        }
        return result;
    }
    static void Main(string[] args)
    {
        try
        {
            int[] array = readArray();
            for (int i = 0; i < array.Length; i++)
            {
                // това първо срещане ли е?
                int j = 0;
                while (j < array.Length && array[i] != array[j])
                    j++;
                if (j == i)
                {
                    int count = 1;
                    for (j++; j < array.Length; j++)
                        if (array[i] == array[j])
                            count++;
                    Console.WriteLine("Число: " + array[i] + ", брой  срещания: " + count);
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Некоректно въведено число");
        }
    }
}
