using System;


class Program
{
    static void Main()
    {
        string input = string.Empty;
        int sum = 0;

        while ((input = Console.ReadLine()) != "end")
        {
            int num = int.Parse(input);
            if (num >= -5 && num <= 5)
            {
               sum+=num;
            }
        }

        Console.WriteLine(sum);
    }
}
