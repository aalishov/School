using System;
using System.Collections.Generic;

namespace P00_SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "aplaysasdasdplay";
            Console.WriteLine(s.IndexOf("play"));
            Console.WriteLine(s.LastIndexOf("play"));  

            char[,] arr = new char[3, 6];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                char[] row=Console.ReadLine().ToCharArray();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = row[j];
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }


            //int[] arr = { 1, 2, 3, 4, 5 };
            //var subsets = CreateSubsets(arr);

            //foreach (var set in subsets)
            //{
            //    foreach (var item in set)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}
        }

        public static List<T[]> CreateSubsets<T>(T[] originalArray)
        {
            List<T[]> subsets = new List<T[]>();

            for (int i = 0; i < originalArray.Length; i++)
            {
                int subsetCount = subsets.Count;
                subsets.Add(new T[] { originalArray[i] });

                for (int j = 0; j < subsetCount; j++)
                {
                    T[] newSubset = new T[subsets[j].Length + 1];
                    subsets[j].CopyTo(newSubset, 0);
                    newSubset[newSubset.Length - 1] = originalArray[i];
                    subsets.Add(newSubset);
                }
            }
            return subsets;
        }
    }
}
