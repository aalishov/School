using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<RacionalNumber> numbers = new List<RacionalNumber>();
        for (int i = 0; i < 3; i++)
        {
            int numerator = int.Parse(Console.ReadLine());
            int denumerator = int.Parse(Console.ReadLine());
            RacionalNumber number = new RacionalNumber() 
            { 
                Numerator = numerator, 
                Denumerator = denumerator 
            };
            numbers.Add(number);
        }
        Console.WriteLine(String.Join($"{Environment.NewLine}",numbers));
    }
}

