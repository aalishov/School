
using System.Collections;
using System.Collections.Generic;

public class Program
{
    static List<string> matrix = new List<string>();
    static List<string> result = new List<string>();
    static void Main(string[] args)
    {
        char[] input = string.Join("", Console.ReadLine().Split(" ")).ToCharArray();

        PermuteNoRepeat(input, 0);


        while (true)
        {
            string cmd = Console.ReadLine();
            if (cmd == "end") { break; }
            if (matrix.Contains(cmd)) 
            { 
                result.Add(cmd);
            }
        }

        foreach (var word in result)
        {
            Console.WriteLine(string.Join(" ", word.ToCharArray()));
        }
    }

    public static void PermuteNoRepeat<T>(T[] array, int index)
    {
        T[] vector = new T[array.Length];
        bool[] used = new bool[array.Length];
        PermuteNoRepeatAlgo(array, vector, used, index);
    }

    private static void PermuteNoRepeatAlgo<T>(T[] array, T[] vector, bool[] used, int index)
    {
        if (index >= vector.Length)
        {
            matrix.Add(string.Join("", vector.ToArray()));
            //Console.WriteLine(string.Join(" ", vector));
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    vector[index] = array[i];
                    PermuteNoRepeatAlgo(array, vector, used, index + 1);
                    used[i] = false;
                }
            }
        }
    }
}

