﻿using System;


class Program
{
    static void Main()
    {
        int magicNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int m = 1; m <= 9;m++)
                        {
                            for (int n = 1; n <= 9; n++)
                            {
                                int product = i * j * k * l * m * n;
                                if (product==magicNumber)
                                {
                                    Console.Write($"{i}{j}{k}{l}{m}{n} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

