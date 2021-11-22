using System;


class Program
{
    //Ctrl+K+D - форматиране на кода
    static void Main()
    {
        Console.WriteLine(PrintRepeatChar());
        Console.WriteLine(PrintRepeatChar('-'));
        Console.WriteLine(PrintRepeatChar('^', 10));
    }
    public static string PrintRepeatChar()
    {
        return new string('*', 25);
    }
    public static string PrintRepeatChar(char c)
    {
        return new string(c, 25);
    }
    public static string PrintRepeatChar(char c, int count)
    {
        return new string(c, count);
    }
}

