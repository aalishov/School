using System;
using System.Collections.Generic;

namespace P02_NestedDicitonary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<int>>> grades = new Dictionary<string, Dictionary<string, List<int>>>();
            Dictionary<string, List<int>> peshoGrades = new Dictionary<string, List<int>>();
            peshoGrades.Add("Math", new List<int>() { 3, 5, 6, 6 });
            peshoGrades.Add("History", new List<int>() { 3, 5, 6, 6 });

            Dictionary<string, List<int>> goshoGrades = new Dictionary<string, List<int>>();
            goshoGrades.Add("Math", new List<int>() { 3, 5, 6, 6 });
            goshoGrades.Add("History", new List<int>() { 3, 5, 6, 6 });
            goshoGrades.Add("Music", new List<int>() { 2, 5, 2, 6 });

            grades.Add("Pesho", peshoGrades);
            grades.Add("Gosho", goshoGrades);

            foreach (var name in grades)
            {
                Console.WriteLine(name.Key);
                foreach (var subject in name.Value)
                {
                    Console.WriteLine($"\t{subject.Key} => {string.Join(", ", subject.Value)}");
                }
            }
        }
    }
}
