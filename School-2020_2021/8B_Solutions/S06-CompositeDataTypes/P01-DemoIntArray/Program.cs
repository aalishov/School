using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        //Достъпване на елементите по индекс и задаване на стойност
        //numbers[0] = 5;
        //numbers[1] = int.Parse(Console.ReadLine());
        //numbers[2] = 18;
        //numbers[2] = 16;
        //numbers[4] = 15;

        Console.WriteLine($"Elements count: {numbers.Length}");
        //Задаване на стойност на елементите
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number [{i}]: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }


        //Отпечатване на елементите
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Element [{i}]: {numbers[i]}");
        }
    }

}

