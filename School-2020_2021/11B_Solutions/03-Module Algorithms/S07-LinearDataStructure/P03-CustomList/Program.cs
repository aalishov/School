using System;
using System.Collections.Generic;

namespace P03_CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 3, 15, 5, 8 };

            Console.WriteLine(string.Join(", ", ShiftRight(3, numbers)));
        }

        public static List<int> ShiftRight(int shiftPosition, List<int> list)
        {
            // 3, 15, 5, 8 => Shift(2)  => //5, 8, 3, 15

            List<int> temp = new List<int>();

            for (int i = 0; i < shiftPosition; i++)
            {
                temp.Add(list[list.Count - 1]);
                for (int j = 0; j < list.Count-1; j++)
                {
                    temp.Add(list[j]);
                }
                list = new List<int>(temp);
                temp.Clear();
            }
            return list;
        }
    }
}
