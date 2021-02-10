using System;

class Program
{
    static void Main()
    {
        string s1 = "Информационни технологии";

        string s2 = s1.Replace("Информационни","*");
        string s3 = s2.Replace("*", "Бит и");
        string s4 = s1.Replace("о", "??");
        string s5 = s1.Replace("и", "@и");

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(s4);
        Console.WriteLine(s5);
    }
}

