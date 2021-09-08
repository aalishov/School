using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student
{
    private readonly SortedDictionary<string, List<int>> grades;

    public Student(int number, string name)
    {
        this.grades = new SortedDictionary<string, List<int>>();
        this.Number = number;
        this.Name = name;
    }
    public int Number { get; set; }

    public string Name { get; set; }

    public void AddGrade(string subject, int grade)
    {
        if (grades.ContainsKey(subject))
        {
            grades[subject].Add(grade);
        }
        else
        {
            grades.Add(subject, new List<int>() { grade });
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Student № {Number} - {Name}");
        foreach (var item in grades)
        {
            sb.AppendLine($"\t{item.Key} -> {string.Join(", ", item.Value.OrderBy(x=>x))}, Average: {item.Value.Average()}");
        }
        sb.AppendLine($"\t=>Average: {grades.Select(x => x.Value.Sum()).Average()/grades.Count}");
        return sb.ToString();
    }
}

