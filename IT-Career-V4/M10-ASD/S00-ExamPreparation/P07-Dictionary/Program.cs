using System;
using System.Collections.Generic;
using System.Text;
public class Program
{
  private  static List<string> variations = new List<string>();
  private  static Dictionary<string,int> variationsDict = new Dictionary<string,int>();
  public  static void Main()
    {
        var data1 = new List<char>();
        for (int i = 'a'; i <= 'z'; i++)
        {
            data1.Add((char)i);
        }
        Variations(data1.ToArray(), 2);
        int index = 1;
        for (int i = 0; i < variations.Count; i++)
        {
            if (variations[i][0] != variations[i][1])
            {
                variationsDict.Add(variations[i],index );
                index++;
            }
        }
        string input = Console.ReadLine();
        if (variationsDict.ContainsKey(input))
        {
            Console.WriteLine(variationsDict[input]);
        }
        else
        {
            Console.WriteLine("No FuFu");
        }

    }
    private static void Variations(char[] array, int k)
    {
        var vector = new int[k];
        while (true)
        {
            VariationPrint(array, vector);
            var index = k - 1;
            while (index >= 0 && vector[index] == array.Length - 1)
            {
                index--;
            }
            if (index < 0) break;
            vector[index]++;
            for (int i = index + 1; i < vector.Length; i++)
            {
                vector[i] = 0;
            }
        }
    }
    private static void VariationPrint(char[] array, int[] vector)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < vector.Length; i++)
        {
            string r = string.Format("{0}", array[vector[i]]);
            sb.Append(r.ToString());
        }
        variations.Add(sb.ToString().TrimEnd());
    }
}

