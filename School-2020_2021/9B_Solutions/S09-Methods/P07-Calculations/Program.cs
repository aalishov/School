using System;


public class Program
{
    static void Main()
    {
        string cmd = Console.ReadLine().ToLower();
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        ExecuteCmd(cmd, x, y);
    }

    public static void ExecuteCmd(string cmd, int x, int y)
    {
        switch (cmd)
        {
            case "add":
                Console.WriteLine(Add(x, y));
                break;
            case "multiply":
                Console.WriteLine(Multiply(x, y));
                break;
            case "subtract":
                Console.WriteLine(Subtract(x, y));
                break;
            case "divide":
                Console.WriteLine(Divide(x, y));
                break;
            default:
                Console.WriteLine("Error!");
                break;
        }
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Divide(int a, int b)
    {
        return a / b;
    }
}

