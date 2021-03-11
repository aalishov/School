using System;


class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 7;

        var result = a > b ? "Greater: a" : "Greater is b";
        Console.WriteLine(result);

        //if (a > b)
        //{
        //    Console.WriteLine("Greater is a");
        //}
        //else
        //{
        //    Console.WriteLine("Greater is b");
        //}
    }
}

