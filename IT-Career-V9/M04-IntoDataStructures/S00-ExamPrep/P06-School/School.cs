using System;
using System.Collections.Generic;
using System.Text;

public class School
{
    private readonly List<Student> students;

    public School(string name)
    {
        Name = name;
        students = new List<Student>();
    }

    public string Name { get; private set; }

    public IReadOnlyCollection<Student> Students
    {
        get { return students; }
    }

    public void AddStudent(string name, double grade)
    {
        students.Add(new Student(name, grade));
    }

    public double AverageResultInRange(int start, int end)
    {
        return students.Skip(start).Take(end - start + 1).Average(s => s.Grade);
    }


    public List<string> RemoveStudentsByGrade(double grade)
    {
        return students.Where(s => s.Grade < grade).Select(s => s.Name).ToList();
    }

    public List<Student> SortAscendingByName()
    {
        List<Student> sorted = students.OrderBy(s => s.Name).ToList();
        students.Clear();
        students.AddRange(sorted);
        return students;
    }

    public List<Student> SortDescendingByGrade()
    {
        List<Student> sorted = students.OrderByDescending(s => s.Grade).ToList();
        students.Clear();
        students.AddRange(sorted);
        return students;
    }

    public bool CheckStudentIsInSchool(string name)
    {
        return students.Any(s => s.Name == name);
    }

    public string[] ProvideInformationAboutAllStudents()
    {
        return students.Select(s => s.ToString()).ToArray();
    }

}

