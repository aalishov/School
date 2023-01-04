using System;

public class Program
{
    public static void Main()
    {
        float num1 = 15.236553f;
        double num2 = 15.236553142342784;
        double num3 = 15.236553142342784d;
        decimal num4 = 15.236553142342784238273894723m;

        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num4);

        string numAsString1 = "10.1566456";
        double realNum = double.Parse(numAsString1);
        //double realNum2 = double.Parse(Console.ReadLine());
        Console.WriteLine(realNum.ToString());
        //Console.WriteLine(realNum2);

        Console.WriteLine(5 / 2m);


        var r2 = float.Parse("12.3");
    }
}

