using System;
using System.Collections;
using System.Linq;

public class Program
{
    private static char[][] arr;
    private static int indexRowM;
    private static int indexColM;
    public static void Main()
    {
        int[] size = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
        arr = new char[size[0]][];

        ReadField();
        Console.WriteLine($"Mice position: {indexRowM}, {indexColM}");
        while (true)
        {
            string cmd = Console.ReadLine();

            switch (cmd)
            {
                case "right":
                    Right();
                    break;
                case "left":
                    Left();
                    break;
                case "end":
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine();
            PrintField();
        }


    }
    private static void Right()
    {
        arr[indexRowM][indexColM] = '*';
        if (indexColM + 1 < arr[indexRowM].Length)
        {
            indexColM++;
        }
        else
        {
            indexColM = 0;
        }
        arr[indexRowM][indexColM] = 'M';
    }
    private static void Left()
    {
        arr[indexRowM][indexColM] = '*';
        if (indexColM - 1 >= 0)
        {
            indexColM--;
        }
        else
        {
            indexColM = arr[indexRowM].Length-1;
        }
        arr[indexRowM][indexColM] = 'M';
    }

    private static void PrintField()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(string.Join(" ", arr[i]));
        }
    }

    private static void ReadField()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Console.ReadLine().ToCharArray();

            for (int j = 0; j < arr[i].Length; j++)
            {
                if (arr[i][j] == 'M')
                {
                    indexRowM = i;
                    indexColM = j;
                }
            }
        }
    }
}