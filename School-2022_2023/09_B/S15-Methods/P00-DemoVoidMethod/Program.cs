using System;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        PrintNumberNegativeOrPositive(num);
    }

    public static void PrintNumberNegativeOrPositive(int num)
    {
        if (num > 0)
        {
            Console.WriteLine($"Number {num} is positive.");
        }
        else if (num < 0)
        {
            Console.WriteLine($"Number {num} is negative.");
        }
        else
        {
            Console.WriteLine("Number is zero");
        }
    }

    //Напишете метод, който получава параметър цяло число и като резултат отпечатва дали е четно или нечетно
    public static void PrintIsEvenOrOdd(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine($"Number {number} is even!");
        }
        else
        {
            Console.WriteLine($"Number {number} is odd!");
        }
    }

    public static void PrintNums(int start, int end, int step = 1)
    {
        for (int i = start; i <= end; i += step)
        {
            Console.WriteLine(i);
        }
    }

    private static void PrintReceipt()
    {
        PrintHeader();
        PrintBody();
        PrintFooter();
    }

    public static void PrintBody()
    {
        Console.WriteLine($"Charged to____________________");
        Console.WriteLine("Received by___________________");
    }
    public static void PrintFooter()
    {
        Console.WriteLine(new string('-', 35));
        Console.WriteLine("© SoftUni");
    }

    public static void PrintHeader()
    {
        Console.WriteLine("PRINT RECEIPT");
        Console.WriteLine(new string('-', 35));
    }
    public static double GetNum()
    {
        return 10;
    }
}