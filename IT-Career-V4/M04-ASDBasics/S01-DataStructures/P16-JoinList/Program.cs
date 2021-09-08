using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main()
    {
        List<int> first = Console.ReadLine() //"10 15 26 5 7"
            .Split(' ') // "10" "15" "26" "5"  "7"
            .Select(int.Parse) //10 15 26 5 7
            .OrderBy(x => x)    //5 7 10 15 26
            .ToList();

        List<int> second = Console.ReadLine() //"10 15 26 5 7"
            .Split(' ') // "10" "15" "26" "5"  "7"
            .Select(int.Parse) //10 15 26 5 7
            .OrderBy(x => x)    //5 7 10 15 26
            .ToList();

        List<int> result = new List<int>();
        //Вариант 1
        //result.AddRange(first);
        //result.AddRange(second);
        //result = result.OrderBy(x => x).ToList();
        //Console.WriteLine(string.Join(", ", result));


        //Add Range
        for (int i = 0; i < first.Count; i++)
        {
            result.Add(first[i]);
        }
        for (int i = 0; i < second.Count; i++)
        {
            result.Add(second[i]);
        }

        //Order By
        int temp = 0;

        for (int write = 0; write < result.Count; write++)
        {
            for (int sort = 0; sort < result.Count - 1; sort++)
            {
                if (result[sort] > result[sort + 1])
                {
                    temp = result[sort + 1];
                    result[sort + 1] = result[sort];
                    result[sort] = temp;
                }
            }
        }

        //String Join
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < result.Count; i++)
        {
            sb.Append(result[i]);
            sb.Append(", ");
        }

        sb.Remove(sb.Length-2,2);
        Console.WriteLine(sb);
    }
}

