using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int mid = n - 2;

        //First row
        Console.WriteLine($"+ {MyString("- ", mid)}+");

        //Middle rows
        for (int i = 0; i < mid; i++)
        {
            Console.WriteLine($"| {MyString("- ", mid)}|");
        }

        //Last row
        Console.WriteLine($"+ {MyString("- ", mid)}+");

    }
    private static string MyString(string s, int count)
    {
        string result = string.Empty;
        for (int i = 0; i < count; i++)
        {
            result += s;
        }
        return result;
    }
}

