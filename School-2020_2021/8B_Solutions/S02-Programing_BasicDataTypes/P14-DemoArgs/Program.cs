using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 15;

        int sum = a % b;

        a++; // постфиксен запис
        ++a; // префиксен запис

        var expression = 15 * ((5 + 12) / a + (12 - 58)) * 12 % 2;
        var expression2 = 15 * 5 + 12 / a + 12 - 58 * 12 % 2;
        Console.WriteLine(expression);
        Console.WriteLine(expression2);
    }
}

