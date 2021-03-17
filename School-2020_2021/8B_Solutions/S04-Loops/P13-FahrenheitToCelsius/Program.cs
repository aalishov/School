using System;

class Program
{
    static void Main()
    {
        double fahrenhait = 0;

        while (fahrenhait<=200)
        {
            double celsius = (fahrenhait - 32) * (5 / 9.0);
            Console.WriteLine($"{fahrenhait,4:f2}°F | {celsius,5:f2}°C");
            fahrenhait += 5;
        }

        //Задачата решена с for
        //for (int i = 0; i <= 200; i+=5)
        //{
        //    double celsius = (i - 32) * (5 / 9.0);
        //    Console.WriteLine($"{i,4:f2}°F | {celsius,5:f2}°C");
        //}
    }
}

