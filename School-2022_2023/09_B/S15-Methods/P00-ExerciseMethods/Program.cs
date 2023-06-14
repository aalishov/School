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
                    result = Method1(x);
                    break;
                case "2":
                    Console.Write("Enter b: ");
                    int b = int.Parse(Console.ReadLine());
                    result = Method2(b);
                    break;
                case "3":
                    Console.Write("Enter x: ");
                    x = int.Parse(Console.ReadLine());
                    result = Method3(x);
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
                    result = Method10(x, q, l, z);
                    break;
                case "11":
                    Console.Write("Enter n: ");
                    int n = int.Parse(Console.ReadLine());
                    Method11(n);
                    break;
                case "13":
                    result = Method13();
                    break;
                case "14":
                    Console.Write("Enter n: ");
                     n = int.Parse(Console.ReadLine());
                    result = Method14(n);
                    break;
                case "end":

                    Environment.ExitCode = 0;
                    break;
            }
            Console.WriteLine($"Result Method{cmd}: {result}");
        }
    }

    public static int Method14(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            int num = Method13(-1000, 1000);
            Console.WriteLine($"Random num {i}: {num}");
            sum += num; //sum = sum+num;
        }
        return sum;
    }

    public static int Method13(int min = -555, int max = 555)
    {
        return new Random().Next(min, max);
    }
    public static void Method11(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(2 * i + 1);
        }
    }
    public static int Method10(int x, int q, int l, int z)
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
    public static int Method3(int x)
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
    public static int Method2(int b)
    {
        int i = (50 / 3) * b;
        int x = (-3 * i) + 5;
        return x;
    }

    public static int Method1(int x)
    {
        int i = (18 % 3) + x;
        int y = 4 * x + i;
        return y;
    }

}