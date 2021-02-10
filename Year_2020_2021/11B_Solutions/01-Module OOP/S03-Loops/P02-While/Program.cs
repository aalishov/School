using System;

namespace P02_While
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = string.Empty;

            while (s!="end")//Докато е вярно изпълнявай
            {
                Console.Write("Enter command: ");
                s = Console.ReadLine();
                switch (s)
                {
                    case "sum":
                        Console.Write("Enter num: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Enter num: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{a} + {b} = {a+b}");
                        break;
                    case "sub":
                        Console.Write("Enter num: ");
                        int c = int.Parse(Console.ReadLine());
                        Console.Write("Enter num: ");
                        int d = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{c} - {d} = {c - d}");
                        break;
                    case "end":
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        Console.WriteLine("Not supported command!");
                        break;
                }
            }
        }
    }
}
