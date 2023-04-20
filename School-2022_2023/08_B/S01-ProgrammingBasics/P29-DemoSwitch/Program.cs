using System;

public class Program
{
    public static void Main(string[] args)
    {
        string cmd = Console.ReadLine();

        switch (cmd)
        {
            case "+":
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"{a}+{b}={a + b}");
                break;
            case "-":
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine($"{a}-{b}={a - b}");
                break;
            default:
                Console.WriteLine("Invalid cmd!");
                break;

        }
        //if (cmd == "+")
        //{
        //    int a = int.Parse(Console.ReadLine());
        //    int b = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"{a}+{b}={a + b}");
        //}
        //else if (cmd == "-")
        //{
        //    int a = int.Parse(Console.ReadLine());
        //    int b = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"{a}-{b}={a - b}");
        //}
        //else { Console.WriteLine("Invalid cmd!"); }
    }
}

