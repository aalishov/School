using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" C   |   F");
        for (double c = 35.0; c < 41.0; c += 0.1)
        {
            double f = (9.0 / 5.0) * c + 32.0;
            Console.Write($"{c,4:##.#} | ");
            Console.Write($"{f,5:##.#}\n");
        }
    }
}

