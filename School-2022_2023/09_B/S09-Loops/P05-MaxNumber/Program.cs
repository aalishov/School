using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int max = int.MinValue;
        //Min
        int min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > max)
            {
                max=num;
            }
            //Min
            //if (num<min)
            //{
            //    min = num;
            //}
        }
        Console.WriteLine(max);
        //Min
        //Console.WriteLine(min);
    }
}

