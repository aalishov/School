using System;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        int num = 0;
        bool isNum = int.TryParse(input, out num);

        while (!isNum || num % 2 == 1)
        {
            if (!isNum)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine("The number is not even.");
            }
            input = Console.ReadLine();
            isNum = int.TryParse(input, out num);
        }

        Console.WriteLine($"Even number entered: {num}");
    }
}

