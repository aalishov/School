using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string dayOrNight = Console.ReadLine();

        double result = 0.0;

        if (n >= 100)
        {
            result =n*0.06;
        }
        else if(n>=20)
        {
            result = n * 0.09;
        }
        else
        {
            result += 0.7;
            if (dayOrNight=="day")
            {
                result += (n * 0.79);
            }
            else
            {
                result += (n * 0.90);
            }
        }

        Console.WriteLine($"{result:f2}");
    }
}

