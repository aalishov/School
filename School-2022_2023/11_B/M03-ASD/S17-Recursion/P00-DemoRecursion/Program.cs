using System;

public class Program
{
    public static void Main()
    {
        A(2);
    }

    public static void A(int a)
    {
        if (a<=0)
        {
            Console.WriteLine("Exit");
            return ;
        }
        Console.WriteLine($"Before recursion: {a}");
        a--;
        A(a);
        Console.WriteLine($"After recursion: {a}");
    }

    public static void B()
    {
        Console.WriteLine(nameof(B));
        C();
    }

    public static void C()
    {
        Console.WriteLine(nameof(C));
        D();
    }

    public static void D()
    {
        Console.WriteLine(nameof(C));
        B();
    }
}