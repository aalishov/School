using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ');

        //Вариант 3
        Func<string, bool> func = (s) => s.FirstOrDefault() >= 'A' && s.FirstOrDefault() <= 'Z';
        
        words
            .Where(x => func(x))
            .ToList()
            .ForEach(x => Console.WriteLine(x));

        //Вариант 2
        //words
        //    .Where(x => char.IsUpper(x.FirstOrDefault()))
        //    .ToList()
        //    .ForEach(x => Console.WriteLine(x));

        //Вариант 1
        //foreach (var item in words)
        //{
        //    if (item[0] >= 'A' && item[0]<='Z')
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

    }
}

