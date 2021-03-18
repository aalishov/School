using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Еnter a number not in the range [1...100]: ");
            int number = int.Parse(Console.ReadLine());
            // bool isValid = !(number >= 1 && number <= 100);
            bool isValid = number <= 1 || number >= 100;
            if (isValid)
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


