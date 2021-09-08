using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main()
    {
        //Типове данни

        char c1 = '@';
        //char c2 = Console.ReadKey().KeyChar;

        string s1= "asdasd";
        //string s2 = Console.ReadLine();

        bool isTrue1 = 5 > 2;
        bool isTrue2 = false;
        bool isTrue3 = 5 != 8;
        bool isTrue4 = double.TryParse("12", out _);
        bool isTrue5 = DateTime.TryParseExact("12-10-2020", "dd-MM-yyyy", CultureInfo.InvariantCulture,DateTimeStyles.None,out _);

        decimal m1 = 12.3m;
        //decimal m2 = decimal.Parse(Console.ReadLine());

        double d1 = 12.3d;
        //double d2 = double.Parse(Console.ReadLine());

        int num1 = 15;
        //int num2 = int.Parse(Console.ReadLine());


        //Console.WriteLine(BigInteger.Pow(11,20));
        //Console.WriteLine(Math.Pow(11,20));

        if (5>2)
        {
            Console.WriteLine(5);
        }
        else
        {
            Console.WriteLine(2);
        }

        string cmd = "print";

        switch (cmd)
        {
            case"print":
                Console.WriteLine("Print");
                break;
            default:
                Console.WriteLine("Error command!");
                break;
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        while (true)
        {
            Console.WriteLine("While body!");
            break;
        }

        do
        {
            Console.WriteLine("Do..While body!");
            
        } while (5<2);

    }
}

