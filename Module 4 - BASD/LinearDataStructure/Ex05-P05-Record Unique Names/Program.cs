using System;
using System.Collections.Generic;

namespace Ex05_P05_Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            Console.WriteLine(string.Join(", ", names));
        }
    }
}
