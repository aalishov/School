using System;


public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 9; i++)
        {
            for (int k = 1; k <= 9; k++)
            {
                for (int l = 1; l <= 9; l++)
                {
                    for (int s = 1; s <= 9; s++)
                    {
                        if (n%i==0&& n % k == 0&& n % l == 0 && n % s == 0)
                        {
                            Console.Write($"{i}{k}{l}{s} ");
                        }
                    }
                }
            }
        }
    }
}

