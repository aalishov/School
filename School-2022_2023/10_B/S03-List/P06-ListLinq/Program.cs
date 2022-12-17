using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<bool> text = new List<bool>();
        int[] nums = new int[10];

        //List<int> list = Console.ReadLine() //"1 5 8 9"
        //    .Split(' ') //["1" "5" "8" "9"]
        //    .Select(int.Parse) //[1 5 8 9]
        //    .Select(x => x * 2) // [2 10 16 18]
        //    .ToList(); //List<int> 1 5 8 9

        List<int> nums1 = new List<int>() { 1, 2, 2, 3, 4 };
        var count = nums.Count(x => x % 2 == 0);
        var contain = nums.Any(x => x != 2);

        List<int> numbers = Enumerable.Range(200, 50).ToList();

        List<int> even = numbers.Where(x => x % 2 == 0).ToList();
        List<int> numBet = numbers.Where(x => x > 210 && x < 220).ToList();
        List<int> numBet2 = numbers.Where(x => x <= 210 || x >= 240).ToList();

        List<int> randomList = new List<int>();
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            randomList.Add(random.Next(-100, 100));
        }

        List<int> sortAsc = randomList.OrderBy(x => x).ToList();
        List<int> sortDesc = randomList.OrderByDescending(x => x).ToList();

        //Console.WriteLine(String.Join(", ", sortAsc));
        //Console.WriteLine(String.Join(", ", sortDesc));


        List<int> nums3 = new List<int>() {12, 7, -3, 2, 4, 8, -3 };
        Console.WriteLine(String.Join(", ", nums3
            .Where(x => x > 4) //12, 7, 8
            .OrderByDescending(x => x)));

    }
}

