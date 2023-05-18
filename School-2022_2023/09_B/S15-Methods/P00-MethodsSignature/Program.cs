using System;
public class Program
{
    public static void Main()
    {
        int result = Calculate1(90);
        Console.WriteLine(result);
    }

    public static int Calculate1(int x)
    {
        int i = (18 % 3) + x;
        int y = 4 * x + i;
        return y;
    }

    public static string Line(char c, int count)
    {
        return new string(c, count);
    }
    public static string Line(int count)
    {
        return new string('*', count);
    }

    public static string Line()
    {
        return new string('*', 10);
    }

    public static int Sum(int a, int b)
    {
        Console.WriteLine(a + b);
        return a + b;
    }

    public static string PrintFullInfo(string name, int age, string address)
    {
        return $"{PrintPersonInfo(name, age)}, address: {address}";
    }

    public static string PrintPersonInfo(string name, int age)
    {
        return $"Name: {name}, age: {age}";
    }

    public static void PrintSum(int a, int b)
    {
        Console.WriteLine(a + b);
    }
}