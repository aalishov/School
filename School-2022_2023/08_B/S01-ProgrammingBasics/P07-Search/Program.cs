using System;

internal class Program
{
    static void Main()
    {
        string s = "Hello World! Hello beautiful World!";

        int index = s.IndexOf("World");
        int index2 = s.LastIndexOf("World");

        Console.WriteLine(index);
        Console.WriteLine(index2);

    }
}

