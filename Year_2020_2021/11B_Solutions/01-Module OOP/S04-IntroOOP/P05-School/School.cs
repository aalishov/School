using System;
using System.Collections.Generic;
using System.Text;


public class School
{
    public School(string name)
    {
        this.Name = name;
        this.Students = new List<Student>();
    }
    public string Name { get; set; }
    public int StudentsCount { get => this.Students.Count; }

    public List<Student> Students { get; set; }

    public string Info()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"=> School: {this.Name}");
        sb.AppendLine($"- Students count: {this.StudentsCount}");

        foreach (var student in this.Students)
        {
            sb.AppendLine(student.Info());
            sb.AppendLine(new string('*', 30));
        }

        return sb.ToString().TrimEnd();
    }
}

