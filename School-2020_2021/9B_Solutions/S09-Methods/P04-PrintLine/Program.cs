using System;

class Program
{
    static void Main(string[] args)
    {
        PrintLine();
        PrintLine('$');
        PrintLine(25);
        PrintLine('/', 3);
        Console.WriteLine(12);
        Console.WriteLine("12");
    }

    public static void PrintLine()
    {
        Console.WriteLine(new string('*',15));
    }
    public static void PrintLine(char c)
    {
        Console.WriteLine(new string(c, 15));
    }
    public static void PrintLine(int count)
    {
        Console.WriteLine(new string('*', count));
    }
    public static void PrintLine(char c,int count)
    {
        Console.WriteLine(new string(c, count));
    }
}
