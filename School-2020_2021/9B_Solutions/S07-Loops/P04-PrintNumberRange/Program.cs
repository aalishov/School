using System;

class Program
{
    static void Main()
    { 
      
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        if (start<end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            for (int i = start; i >= end; i--)
            {
                Console.WriteLine(i);
            }
        }

    }
}

