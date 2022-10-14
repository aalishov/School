using System;
using System.Collections.Generic;
//using System.Linq;

class Program
{
    public static void Main()
    {
        //Примитивни типове данни
        int n1 = 0;
        short n2 = 8;
        bool isTrue = 5 > 2 || true;
        char c = 'c';
        double d = 12d;
        decimal d1 = 15.2m;

        string s = "asdasd";

        int[] nums1 = new int[] { 1, 2, 3 };
        int[] nums2 = nums1;

        ChangeNums(nums2);
        Console.WriteLine(string.Join(" | ", nums1));

        Dictionary<string, double> salary = new Dictionary<string, double>();

        salary.Add("Ivan", 1000);

        bool isAdd = salary.TryAdd("Ivans", 5000);

        salary["Ivan"] = 2000;
        foreach (var item in salary)
        {
            Console.WriteLine($"{item.Key} => {item.Value}");
        }

        HashSet<int> nums3 = new HashSet<int>();
        nums3.Add(1);
        nums3.Add(1);
        nums3.Add(3);

        Console.WriteLine(String.Join(", ",nums3));
    }

    public static void ChangeNum(int n)
    {
        n += 10;
    }
    public static void ChangeNums(int[] n)
    {
        n[0] += 10;
    }
}

