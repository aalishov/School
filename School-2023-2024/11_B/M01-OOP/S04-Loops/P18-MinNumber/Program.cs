using System;
public class Program
{
    public static void Main()
    {
        int min = int.MaxValue;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Stop")
            {
                break;
            }
            int n = int.Parse(input);
            if (n < min)
            {
                min = n;
            }
        }
        Console.WriteLine(min);
    }
}
