using System;


internal class Program
{
    static void Main()
    {
        int maxNum = int.MinValue;
        string input = String.Empty;

        while ((input=Console.ReadLine()) != "Stop")
        {
            int newNum = int.Parse(input);
            if (newNum > maxNum)
            {
                maxNum = newNum;
            }

        }
        Console.WriteLine(maxNum);
    }
}

