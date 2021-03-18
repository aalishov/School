using System;

class Program
{
    static void Main()
    {
        bool isNotZero = true;
        int sum = 0;
        do
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            sum += number;
            if (number == 0)
            {
                isNotZero = false;
            }
        } while (isNotZero);
        Console.WriteLine($"Sum: {sum}");
    }
}

