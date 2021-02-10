using System;
using System.Collections.Generic;
using System.Text;


public class School
{
    //Конструктор
    public School(string name)
    {
        this.Name = name;
        this.Students = new List<Student>();
    }

    //Свойства
    public string Name { get; set; }
    public int StudentsCount { get => this.Students.Count; }

    public List<Student> Students { get; set; }

    //Метод
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

