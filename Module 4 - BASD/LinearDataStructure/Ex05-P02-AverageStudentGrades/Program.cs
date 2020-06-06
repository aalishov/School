using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex05_P02_AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<double>> students = new SortedDictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students.Add(name, new List<double> { grade });
                }
            }

            foreach (var student in students.OrderByDescending(x=>x.Value.Average()))
            {
                Console.WriteLine($"{student.Key} -> {string.Join(", ", student.Value)} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
