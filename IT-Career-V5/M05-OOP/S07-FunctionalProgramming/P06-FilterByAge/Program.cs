using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static Dictionary<string, int> people = new Dictionary<string, int>();
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            string[] info = Console.ReadLine().Split(", ");
            people.Add(info[0], int.Parse(info[1]));
        }
        string condition = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string format = Console.ReadLine();

        Func<int, bool> func = x => condition == "older" ? x >= age : x < age;

        people = people
            .Where(x => func(x.Value))
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var item in people)
        {
            string result = "";
            if (format == "age")
            {
                result = $"{item.Value}";
            }
            else if (format == "name")
            {
                result = $"{item.Key}";
            }
            else
            {
                result = $"{item.Key} - {item.Value}";
            }
            Console.WriteLine(result);
        }
    }
}

