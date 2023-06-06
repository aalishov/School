using System;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Write("Enter command: ");
            string cmd = Console.ReadLine();
            int result = 0;
            switch (cmd)
            {
                case "1":
                    Console.Write("Enter x: ");
                    int x = int.Parse(Console.ReadLine());
                    result= Calculate1(x);
                    break;
                case "2":
                    Console.Write("Enter b: ");
                    int b = int.Parse(Console.ReadLine());
                    result= Calculate2(b);
                    break;
                case "3":
                    Console.Write("Enter x: ");
                     x = int.Parse(Console.ReadLine());
                    result = Calculate3(x);
                    break;
                case "10":
                    Console.Write("Enter x: ");
                     x = int.Parse(Console.ReadLine());
                    Console.Write("Enter q: ");
                    int q = int.Parse(Console.ReadLine());
                    Console.Write("Enter l: ");
                    int l = int.Parse(Console.ReadLine());
                    Console.Write("Enter z: ");
                    int z = int.Parse(Console.ReadLine());
                    result = Calculate10(x,q,l,z);
                    break;
                case "end":
                    Environment.ExitCode = 0;
                    break;
            }
            Console.WriteLine($"Result Calculate{cmd}: {result}");
        }
    }
    public static int Calculate10(int x, int q, int l, int z)
    {
        if (x > 4)
        {
            return 2 * x + 5 * q;
        }
        else if (x <= 0)
        {
            return x * x + 2 * z;
        }
        else
        {
            return 3 * x * x * x + q;
        }
    }
    public static int Calculate3(int x)
    {
        if (x > 4)
        {
            return 2 * x + 3;
        }
        else if (x <= 1)
        {
            return x * x + 4 * x;
        }
        else { return 3 * x * x; }
    }
    public static string RandomPass()
    {
        Random random = new Random();
        int a = random.Next(9);
        int b = random.Next(9);
        int c = random.Next(9);
        int d = random.Next(9);
        return $"{a}{b}{c}{d}";
    }
    public static string RepeatString(string s, int n)
    {
        string result = "";
        for (int i = 0; i < n; i++)
        {
            result += s;


        }
        return result;
    }
    public static int Calculate2(int b)
    {
        int i = (50 / 3) * b;
        int x = (-3 * i) + 5;
        return x;
    }

    public static int Calculate1(int x)
    {
        int i = (18 % 3) + x;
        int y = 4 * x + i;
        return y;
    }

}