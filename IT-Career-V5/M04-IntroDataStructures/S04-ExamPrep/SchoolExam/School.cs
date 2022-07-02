using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class School
{
    private List<Student> students;
    public School(string name)
    {
        this.Name = name;
        this.students = new List<Student>();
    }
    public string Name { get; private set; }
    public List<Student> Students
    {
        get { return this.students; }                 
    }
    public void AddStudent(string name, double grade)
    {
        this.students.Add(new Student(name, grade));               
    }
    public double AverageResultInRange(int start, int end)
    {
        return this.students.GetRange(start, end - start + 1).Average(x => x.Grade);          
    }
    public List<string> RemoveStudentsByGrade(double grade)
    {
        List<string> removedStudetns = this.students
            .Where(x=>x.Grade<grade)
            .Select(x=>x.Name)
            .ToList();
        this.students.RemoveAll(x => x.Grade < grade);
        return removedStudetns;
    }
    public List<Student> SortAscendingByName()
    {
        this.students=this.students.OrderBy(x => x.Name).ToList();
        return this.students;
    }
    public List<Student> SortDescendingByGrade()
    {
        this.students = this.students.OrderByDescending(x => x.Grade).ToList();
        return this.students;
    }
    public bool CheckStudentIsInSchool(string name)
    {
        foreach (var s in this.students)
        {
            if (s.Name==name)
            {
                return true;
            }
        }
        return false;
        //return this.students.Any(x => x.Name == name);
    }
    public string[] ProvideInformationAboutAllStudents()
    {
        return this.students.Select(x => x.ToString()).ToArray();
    }
}

