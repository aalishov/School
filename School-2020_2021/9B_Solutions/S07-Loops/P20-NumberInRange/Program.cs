using System;

class Program
{
    static void Main()
    {

        while (true)
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            int number = int.Parse(Console.ReadLine());
            if (number >= 1 && number <= 100)
            {
                Console.WriteLine($"The number is: {number}");
                break;
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}

