using System;


class Program
{
    static void Main()
    {
        // sbyte num = 127;

        //ushort num = -3; //Build error

        int firstNumber = -100;
        int secondNumber = 20;

        Console.WriteLine($"{firstNumber}+{secondNumber}={firstNumber+secondNumber}");
        Console.WriteLine($"{firstNumber}-{secondNumber}={firstNumber - secondNumber}");
        Console.WriteLine($"{firstNumber}*{secondNumber}={firstNumber * secondNumber}");
        Console.WriteLine($"15/8={15/8}");
        Console.WriteLine($"15%8={15 % 8}");
        Console.WriteLine($"9/4={9 / 4}");
        Console.WriteLine($"9%4={9 % 4}");

        int resultPart = 154 % 31;
        int resultAll = 154 / 31;
        Console.WriteLine(resultPart);
        Console.WriteLine(resultAll);

        int num = 10;
        num += 5; //num=num+5;
        Console.WriteLine(num);

        Console.WriteLine($"Max value: {int.MaxValue}");
        Console.WriteLine($"Min value: {int.MinValue}");
    }
}

