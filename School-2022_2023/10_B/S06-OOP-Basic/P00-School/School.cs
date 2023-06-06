using System;
using System.Collections.Generic;
using System.Text;

public class School
{
    public string Name { get; set; }

    public string City { get; set; }

    public int StudentsCapacity { get; set; }

    public List<Teacher> Teachers { get; set; } = new List<Teacher>();

    public List<Student> Students { get; set; } = new List<Student>();
}