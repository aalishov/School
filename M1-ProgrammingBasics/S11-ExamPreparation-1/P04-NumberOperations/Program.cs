using System;

class Program
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        string c = Console.ReadLine();

        switch (c)
        {
            case "+":
                int sum = n1 + n2;
                Console.WriteLine($"{n1} {c} {n2} = {sum} - {EvenOrOdd(sum)}");
                break;
            case "-":
                int diff = n1 - n2;
                Console.WriteLine($"{n1} {c} {n2} = {diff} - {EvenOrOdd(diff)}");
                break;
            case "*":
                int prod = n1 * n2;
                Console.WriteLine($"{n1} {c} {n2} = {prod} - {EvenOrOdd(prod)}");
                break;
            case "/":
                if (n2==0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} / {n2} = {n1/(double)n2:f2}");
                }
                break;
            case "%":
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                }
                break;
            default:
                break;
        }
    }
    static string EvenOrOdd(int num)
    {
        if (num%2==0)
        {
            return "even";
        }
        else
        {
            return "odd";
        }
    }
}
