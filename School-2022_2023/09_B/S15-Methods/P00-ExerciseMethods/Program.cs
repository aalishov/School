using System;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Calculate3(5));
        Console.WriteLine(Calculate3(-1));
        Console.WriteLine(Calculate3(2));
    }
    public static int Calculate3(int x)
    {
        if (x>4)
        {
            return 2*x + 3;
        }
        else if (x<=1)
        {
            return x * x + 4 * x; 
        }
        else { return 3 * x * x; }
    }
    public static string RandomPass()
    {
        Random random= new Random();
       int a=  random.Next(9);
       int b= random.Next(9);
       int c= random.Next(9);
       int d= random.Next(9);
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