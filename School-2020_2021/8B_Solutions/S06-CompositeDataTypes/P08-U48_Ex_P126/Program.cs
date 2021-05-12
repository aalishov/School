using System;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.Write("Enter number p: ");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter numbers separeted with whitespace: ");
        int[] numbers = Console.ReadLine() //"15 10 20 30"
            .Split(' ') //"15" "10" "20" "30"
            .Select(int.Parse) //15 10 20 30
            .ToArray();

        int evenCounter = 0;
        int oddCounter = 0;
        int pCounter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]%2==0)
            {
                evenCounter++; //evenCounter=evenCounter+1;
            }
            else
            {
                oddCounter++; //oddCounter=oddCounter+1;
            }

            if (numbers[i]==p)
            {
                pCounter++;
            }
        }

        Console.WriteLine($"Even numbers count: {evenCounter}");
        Console.WriteLine($"Odd numbers count: {oddCounter}");
        Console.WriteLine($"P count: {pCounter}");
    }
}

