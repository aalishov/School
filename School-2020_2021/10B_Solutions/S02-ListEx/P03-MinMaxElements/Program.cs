using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine() //Чете ред
            .Split(' ') //Разделяме по интервал
            .Select(int.Parse) //Преобразуваме ги в цели числа
            .ToList();

        int min = nums.Min(); //Намираме минималния елемент
        int max = nums.Max();   //Намираме максималния елемент

        List<int> result = nums
            .Where(x => x == min || x == max) //Филтриране на всички, които са равни на минималния или максималния елемент
            .OrderBy(x => x) //Сортиране във възходящ ред
            .ToList();

        Console.WriteLine($"Numbers equal to min ana max: => {string.Join(" | ", result)}");
    }
}

