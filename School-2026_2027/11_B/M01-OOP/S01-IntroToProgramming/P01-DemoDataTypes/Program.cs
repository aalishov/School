using System;

public class Program
{
    public static void Main()
    {
        // +, -, *, /, %, ++, --
        int num = 10;
        byte num1 = 255;
        short num2 = 30000;
        long num3 = 10000000000; //long.MaxValue, long.MinValue

        //Console.WriteLine(19/9); //2
        //Console.WriteLine(19%9); //1

        num += 100; //num = num + 100;  

        //+, -, *, /, %, ++, --
        float f = 3.14455646465465465465465465454f; //3.1445565
        double d = 3.14455646465465465465465465454; //3.1445564646546544
        decimal dec = 3.14455646465465465465465465454m; //3.1445564646546546546546546545

        //>, <, >=, <=, ==, !=
        //&&, ||, !
        bool isTrue = true;
        bool isTrue1 = false;

        // +
        string s = "Hello, World!";
        //string? consoleResult = Console.ReadLine();
        string name = "John Doe";
        string s1 = $"Name: {name}";
        Console.WriteLine(s1);

        char c = 'A';
        char c1 = '*';

        Console.WriteLine("");

    }
}

