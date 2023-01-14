using System;



internal class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num<100)
        {
            Console.WriteLine("Less than 100");
        }
        else if (num>200)
        {
            Console.WriteLine("Greater than 200");
        }
        else
        {
            Console.WriteLine("Between 100 and 200");
        }
    }
}

