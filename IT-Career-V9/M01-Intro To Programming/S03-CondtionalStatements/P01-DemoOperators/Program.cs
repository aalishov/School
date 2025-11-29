using System.Timers;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode; 2

        char symbol = '@';

        //string text = Console.ReadLine();
        string name = "John";

        int num1 = 15;
        int num2 = ((15 + 2) * 15 / 9) % 2;
        double num3 = 15.34564654654654654654654654654654;
        decimal num4 = 15.34564654654654654654654654654654m;

        bool isTrue = true;
        bool isTrue2 = false;
        bool isTrue3 = !(5 != 3 + 2);

        int x = 15;

        bool isTrue4 = !(x > -10 && x < 10);

        if (x <= -10 || x >= 10)
        {
            Console.WriteLine("(-∞;-10] [10;+∞)");
        }
        else
        {
            Console.WriteLine(x);
        }

        Console.WriteLine();
    }
}


