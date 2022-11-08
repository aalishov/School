using System;

public class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        Console.WriteLine(RepeatString(str,count));
    }
    static string RepeatString(string str, int count)
    {
        string result = string.Empty;
        for (int i = 0; i < count; i++)
        {
            result += str;
        }
        return result;
    }
}

