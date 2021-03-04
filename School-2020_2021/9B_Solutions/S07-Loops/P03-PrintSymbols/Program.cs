using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 0; i <= 10000; i++)
        {
            Console.WriteLine($"{i}=>{(char)i}");
        }
    }
}

