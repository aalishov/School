using System;

class Program
{
    static void Main()
    {

        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 100) // !(n < 1 || n > 100) <=> (n >= 1 && n <= 100)
            {
                Console.WriteLine($"The number is: {n}");
                break;
            }
            Console.WriteLine("Invalid number!");
        }


    }
}

