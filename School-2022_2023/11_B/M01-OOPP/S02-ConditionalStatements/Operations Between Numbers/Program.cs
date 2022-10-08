using System;



internal class Program
{
    static void Main()
    {
        double N1=double.Parse(Console.ReadLine());
        double N2=double.Parse(Console.ReadLine());
        string op= Console.ReadLine();

        double result = 0;

        switch (op)
        {
            case "+":
                result = N1 + N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} + {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} + {N2} = {result} - odd");
                }
                
                break;
                case "-":
                result = N1 - N2;
                if (result%2==0)
                {
                    Console.WriteLine($"{N1} - {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} - {N2} = {result} - odd");
                }
                break;
            case "*":
                result = N1 * N2;
                if (result%2==0)
                {
                    Console.WriteLine($"{N1} * {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} * {N2} = {result} - odd");
                }
                break;
            case "/":
                if (N2==0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    result=N1 / N2;
                    Console.WriteLine($"{N1} / {N2} = {result:f2}");
                }
                break;
            case "%":
                if (N2==0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    result=N1% N2;
                    Console.WriteLine($"{N1} % {N2} = {result}");
                }
                break;
        }
    }
}

