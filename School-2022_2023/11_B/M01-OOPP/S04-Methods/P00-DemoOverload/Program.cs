using System;
class Program
{
    static void Main()
    {
        for (int i = 15; i >= 5; i--)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}