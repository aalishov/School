using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(MethodD());
    }

    static int MethodA()
    {
        return 2 + 3;
    }

    static int MethodB()
    {
        return 2 + 3;
    }

    static int MethodC()
    {
        return MethodA() + MethodB();
    }

    static int MethodD()
    {
        return MethodC() + 15;
    }
}

