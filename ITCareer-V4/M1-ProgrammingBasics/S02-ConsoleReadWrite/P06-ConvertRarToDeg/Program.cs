using System;


class Program
{
    static void Main()
    {
        
        double rad = double.Parse(Console.ReadLine());

        //1 rad × 180 / π = 57,296 °

        double g =Math.Round( rad * 180 / Math.PI,2);

        Console.WriteLine(g);
    }
}

