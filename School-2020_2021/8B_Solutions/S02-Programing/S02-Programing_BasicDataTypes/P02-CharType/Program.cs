using System;
using System.Text;

class Program
{
    static void Main()
    {
        //char - символ
        char symbol1 = '@';
        int symbol1Num = '@';
        char number = '5';
        char letter1 = 'a';
        char letter2 = 'A';
        int numA = 'A';

        char numChar = (char)99;

        Console.WriteLine($"{symbol1} => {symbol1Num}");
        Console.WriteLine($"{letter2} => {numA}");
        Console.WriteLine(numChar);


        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 1; i <= 1000; i++)
        {
            Console.WriteLine($"{i} = {(char)i}");
        }
    }
}

