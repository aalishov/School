using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter even number: ");
            string input = Console.ReadLine();
            int number = 0;
            bool isNumber = int.TryParse(input, out number);
            if (isNumber)
            {
                bool isEven = number % 2 == 0;
                if (isEven)
                {
                    Console.WriteLine($"Even number entered: {number}");
                    break;
                }
                else
                {
                    Console.WriteLine("The number is not even.");
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}

