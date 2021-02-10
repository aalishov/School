using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] nums = new int[] { 15, -12, 36, 6, 58, 48, -2, -10, 0, 9, -17 };
        List<int> numbers = new List<int>(nums);
        numbers.Add(-56);

        Console.WriteLine($"All: {string.Join(", ", numbers)}");

        //Филтриране - Where
        //--Положителни числа
        List<int> positiveNums = numbers
            .Where(num => num > 0)
            .ToList();
        Console.WriteLine($"Positive numbers: {string.Join(", ", positiveNums)}");
        //Числа в интервала [-10:10]
        List<int> intervalNums = numbers
            .Where(n => n >= -10 && n <= 10)
            .ToList();
        Console.WriteLine($"Numbers [-10:10]: {string.Join(", ", intervalNums)}");

        //Сортиране - OrderBy, OrderByDescending
        //Възходящ ред
        List<int> sortASC = numbers.OrderBy(x => x).ToList();
        Console.WriteLine($"ASC sort: {string.Join(", ", sortASC)}");
        //Низходящ ред
        List<int> sortDESC = numbers.OrderByDescending(x => x).ToList();
        Console.WriteLine($"DESC sort: {string.Join(", ", sortDESC)}");

        //Сортиране и филтриране
        //Сортирани числа в интервала [-10:10]
        List<int> intervalAndSortNums = numbers
                .Where(n => n >= -10 && n <= 10)
                .OrderBy(x=>x)
                .ToList();
        Console.WriteLine($"Sorted numbers [-10:10]: {string.Join(", ", intervalAndSortNums)}");

        //Първи и последен елемент - Firs, Last
        int firstNum = numbers.First();
        int lastNum = numbers.Last();
        Console.WriteLine($"Първи: {firstNum}, последен: {lastNum}");

        //Пропускане и взимане на определен брой елементи -Skip, Take
        //Пропусни 3 елемента и вземи 4 елемента
        List<int> skipTakeElements = numbers.Skip(3).Take(4).ToList();
        Console.WriteLine($"Пропусни 3 елемента и вземи 4 елемента: {string.Join(", ",skipTakeElements)}");

        //Проекции - Select
        //Добавяне на единица към всички елементи
        List<int> numbersWithAdded1 = numbers.Select(x => ++x).ToList();
        Console.WriteLine($"Добавяне на 1 към всеки елемент: {string.Join(", ",numbersWithAdded1)}");
        //Всички елементи *10
        List<int> numbers10 = numbers.Select(x => x*=10).ToList();
        Console.WriteLine($"Всички елементи *10: {string.Join(", ", numbers10)}");
    }


}

