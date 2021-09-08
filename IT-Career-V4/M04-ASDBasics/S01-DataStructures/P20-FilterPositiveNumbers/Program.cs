using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> array = new List<int> { 19, -10, 12, -6, -3, 34, -2, 5 };

        //Вариант 1
        //Console.WriteLine(string.Join(", ", array.Where(x => x > 0)));

        //Вариант 2
        List<int> positiveNumbers = new List<int>();
        for (int i = 0; i < array.Count; i++)
        {
            if (array[i]>0)
            {
                positiveNumbers.Add(array[i]);
            }
        }

        Console.WriteLine(string.Join(", ",positiveNumbers));
    }
}

