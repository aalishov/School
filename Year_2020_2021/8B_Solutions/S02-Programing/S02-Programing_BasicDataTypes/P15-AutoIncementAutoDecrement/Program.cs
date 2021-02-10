using System;

class Program
{
    static void Main()
    {
        int a = 0;
        a++; // a=a+1; , a=1
        a++; // a=a+1; , a=2
        a++; // a=a+1; , a=3  
        a--; // a=a-1; , a=2
        ++a; // a=a+1; , a=3
        ++a; // a=a+1; , a=4
        Console.WriteLine($"a={a}");

        int b = 0;
        Console.WriteLine($"b={b++}"); //cw => 0, b=b+1;
        Console.WriteLine($"b={++b}"); //b=b+1, cw =>2 ?

        int c = 2;
        Console.WriteLine($"c={c++ * 2}"); //Print c=4
        Console.WriteLine($"c={c * 2}");   //Print c=6
        Console.WriteLine($"c={++c * 2}");   //Print c=8

        int d = 5;
        // 1) d*2 => 5*2=10
        // 2) Отпечатване на конзолата d=10
        // 3) Намаляваме d с 1 => d=d-1 =>d=4
        Console.WriteLine($"d={d-- * 2}");
        // 1) d*2 => 4*2=8
        // 2) Отпечатване на конзолата d=8
        Console.WriteLine($"d={d * 2}");
        // 1) Намаляваме d с 1 => d=d-1 =>d=3
        // 2) 1) d*2 => 3*2=6
        // 3) Отпечатване на конзолата d=6
        Console.WriteLine($"d={--d * 2}");
    }
}

