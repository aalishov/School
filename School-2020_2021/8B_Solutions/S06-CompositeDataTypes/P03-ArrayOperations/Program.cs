using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        double[] numbers = Console.ReadLine() // "7 8 9 10 11"
             .Split(' ') //"7" "8" "9" "10" "11"
             .Select(double.Parse) // 7 8 9 10 11
             .ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] *= 3; //numbers[i]=numbers[i]*3;
        }

        Console.WriteLine(string.Join(" | ",numbers));
    }
}

