using System;

namespace P01_SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = "+";
            int a = 25;
            int b = 6;

            //switch (operation)
            //{
            //    case "+":
            //        Console.WriteLine("Case sum:");
            //        Console.WriteLine($"{a} + {b} = {a+b}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"{a} - {b} = {a - b}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"{a} * {b} = {a * b}");
            //        break;
            //    case "/":
            //        Console.WriteLine($"{a} / {b} = {a / b}");
            //        break;
            //    case "%":
            //        Console.WriteLine($"{a} % {b} = {a % b}");
            //        break;
            //    case "sqrt":
            //        Console.WriteLine($"sqrt {a} = {Math.Sqrt(a)}");
            //        Console.WriteLine($"sqrt {b} = {Math.Sqrt(b)}");
            //        break;
            //    default:
            //        Console.WriteLine("Error!");
            //        break;
            //}

            if (operation=="+")
            {
                Console.WriteLine("Case sum:");
                Console.WriteLine($"{a} + {b} = {a + b}");
            }
            else if (operation == "-")
            {
                Console.WriteLine($"{a} - {b} = {a - b}");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
