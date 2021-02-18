using System;

class Program
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        //Console.ReadLine()[0]
        //Console.ReadLine().First()
        char o = Console.ReadKey().KeyChar;
        Console.WriteLine();
        switch (o)
        {
            case '+':
                int sum = n1 + n2;
                string evenOrOdd = ((n1 + n2) % 2) == 0 ? "even" : "odd";
                Console.WriteLine($"{n1} + {n2} = {sum} - {evenOrOdd}");
            break;
            case '-':
                int diff = n1 - n2;
                var evenOrOddDiff = ((n1 - n2) % 2) == 0 ? "even" : "odd";
                Console.WriteLine($"{n1} - {n2} = {diff} - {evenOrOddDiff}");
                break;
            case '*':
                Console.WriteLine($"");
                break;
            case '/':
                Console.WriteLine($"");
                break;
            case '%':
                Console.WriteLine($"");
                break;
            default:
                break;
        }
    }
}

