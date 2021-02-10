using System;


class Program
{
    static void Main()
    {
        string nums = string.Empty;

        for (int i = 1; i <= 1000; i++)
        {
            if (i % 10 == 7)
            {
                nums += $"{i} ";
            }
        }
        Console.WriteLine(nums);
    }
}

