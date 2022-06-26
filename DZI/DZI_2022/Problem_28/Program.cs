using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string fileName = Console.ReadLine() + ".txt";
        int k = int.Parse(Console.ReadLine());
        List<int> line = MethodC(fileName);
        MethodA(line, k);
        line=MethodB(line);
        string result = string.Join(" ", line);
        Console.WriteLine(result);

    }
    static void MethodA(List<int> line, int k)
    {
        List<int> remove = new List<int>();
        for (int i = 0; i < line.Count; i++)
        {
            int sum = 0;
            int num = line[i];
            while (num > 0)
            {
                int m = num % 10;
                sum = sum + m;
                num = num / 10;
            }
            if (sum % k == 0)
                remove.Add(line[i]);
        }
        remove.ForEach(x => line.Remove(x));
    }
    static List<int> MethodB(List<int> line)
    {
        return line.OrderBy(x => SumOfDigits(x)).ToList();
    }
    static List<int> MethodC(string fileName)
    {
        List<int> collection = new List<int>();
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    int num = int.Parse(line);
                    collection.Add(num);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return collection;
    }
    static int SumOfDigits(int x)
    {
        int sum = 0;
        int num = x;
        while (num > 0)
        {
            int m = num % 10;
            sum = sum + m;
            num = num / 10;
        }
        return sum;
    }
}

