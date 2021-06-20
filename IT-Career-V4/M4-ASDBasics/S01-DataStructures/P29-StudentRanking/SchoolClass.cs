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

}

