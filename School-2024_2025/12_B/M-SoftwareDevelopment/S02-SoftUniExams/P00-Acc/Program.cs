using System;

class Program
{
   static int counter = 0;
    static void Main()
    {
        int m = 4;
        int n = 5;

        Console.WriteLine("Ackermann({0}, {1}) = {2}", m, n, Ackermann(m, n));
    }

    static int Ackermann(int m, int n)
    {
       // Console.WriteLine(++counter);
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}
