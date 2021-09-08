using System;
using System.Collections.Generic;
using System.Text;

public class SchoolClass
{
    private readonly List<Student> students;
    public SchoolClass(string name)
    {
        this.students = new List<Student>();
        this.Name = name;
    }
    public string Name { get; set; }

    public string Teacher { get; set; }

    public void Add(Student student)
    {
        this.students.Add(student);
    }


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Class: {this.Name}");
        foreach (var student in students)
        {
            sb.AppendLine($"\t{student.ToString()}");
        }
        return sb.ToString();
    }
}

