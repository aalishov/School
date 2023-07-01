using System.Collections.Generic;
using System.Linq;


public class School
{
    private List<Student> students;

    public School()
    {
        students = new List<Student>();
    }

    public School(string name) : this()
    {
        this.Name = name;
    }

    public string Name { get; private set; }

    public IReadOnlyList<Student> Students
    {
        get { return students; }
    }

    public void AddStudent(string name, double grade)
    {
        students.Add(new Student(name, grade));
    }

    public double AverageResultInRange(int start, int end)
    {
        //List<Student> group = new List<Student>();
        //for (int i = start; i <= end; i++)
        //{
        //    group.Add(students[i]);
        //}
        //return group.Average(x=>x.Grade);

        //TODO: Check index

        return students.Skip(start).Take(end - start + 1).Average(x => x.Grade);
    }

    public List<string> RemoveStudentsByGrade(double grade)
    {
        return students
            .Where(x => x.Grade < grade)
            .Select(x => x.Name)
            .ToList();
    }

    public List<Student> SortAscendingByName()
    {
        students = students.OrderBy(x => x.Name).ToList();
        return students;
    }

    public List<Student> SortDescendingByGrade()
    {
        students = students.OrderByDescending(x => x.Grade).ToList();
        return students;
    }

    public bool CheckStudentIsInSchool(string name)
    {
        return students.Any(x => x.Name == name);
    }

    public string[] ProvideInformationAboutAllStudents()
    {
        return students.Select(x=>x.ToString()).ToArray();  
    }
}
