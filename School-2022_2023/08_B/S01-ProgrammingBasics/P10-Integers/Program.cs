using System;

public class Program
{
    public static void Main()
    {
        byte n1 = 255;
        int n2 = 1024;
        long n4 = 1024 * 1024;


        
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);

        int b = 16 / 3;
        int c = 16 % 3; //Модулно деление

        Console.WriteLine(b);
        Console.WriteLine(c);

        string num = "15";
        int num1=int.Parse(num);
        int num2 = int.Parse(Console.ReadLine());

        string result2 = num2.ToString();

    }
}

