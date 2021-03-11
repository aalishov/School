using System;

class Program
{
    //Страница 96 / задача 2
    static void Main()
    {
        Console.Write("Enter numbers count: ");
        int n = int.Parse(Console.ReadLine());

        int min =int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            
            if (number<min)
            {
                min = number;
            }
        }
        Console.WriteLine($"Min number: {min}");
    }
}

