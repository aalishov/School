using System;

public class Program
{
    public static void Main()
    {
        bool[] isSnowy = new bool[4];

        for (int i = 0; i < isSnowy.Length; i++)
        {
            isSnowy[i] = bool.Parse(Console.ReadLine());
        }
        Console.WriteLine(string.Join(", ",isSnowy));
    }
}

