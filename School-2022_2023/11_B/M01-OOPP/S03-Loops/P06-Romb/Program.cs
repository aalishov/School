using System;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //Top
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string(' ', n - i) + MyString("* ", i));
        }
        //Bottom
        for (int i = n - 1; i > 0; i--)
        {
            Console.WriteLine(new string(' ', n - i) + MyString("* ", i));
        }
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

