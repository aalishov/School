using System;

class Program
{
    static void Main()
    {
        char c = '@';
        char c2 = (char)60;

        int num = 'z';
        Console.WriteLine($"{num}=>{(char)num}");
        Console.WriteLine($"{num-1}=>{(char)(num-1)}");
    }
}

