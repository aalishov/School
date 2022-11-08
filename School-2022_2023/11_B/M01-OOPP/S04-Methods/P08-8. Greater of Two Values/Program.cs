using System;


public class Program
{
    static void Main()
    {
        Run();
    }

    public static void Run()
    {
        string cmd = Console.ReadLine();
        switch (cmd)
        {
            case "int":
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
                break;
            case "char":
                char c1 = char.Parse(Console.ReadLine());
                char c2 = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(c1, c2));
                break;
            case "string":
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();
                Console.WriteLine(GetMax(s1, s2));
                break;
        }
    }

    static int GetMax(int a, int b)
    {
        if (a > b) { return a; }
        else { return b; }
    }
    static char GetMax(char a, char b)
    {
        if (a > b) { return a; }
        else { return b; }
    }
    static string GetMax(string a, string b)
    {
        for (int i = 0; i < Math.Min(a.Length, b.Length); i++)
        {
            if (a[i] > b[i]) { return a; }
            else if (b[i] > a[i]) { return b; }
        }
        if (a.Length > b.Length) { return a; }
        else { return b; }
    }

}

