using System;

class Program
{
    static void Main()
    {
        int sum = 0;

        bool isNotZero = false;

        //Докато е вярно, цикъл с предусловие, може и да не се изпълни

        while (isNotZero)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number==0)
            {
                isNotZero = false;
            }
            sum += number;
        }
        Console.WriteLine($"Sum: {sum}");
    }
}

