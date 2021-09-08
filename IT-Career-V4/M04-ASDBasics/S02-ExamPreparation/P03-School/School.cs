using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03_School
{
    public class School
    {
        private List<Student> students;
        public School()
        {
            this.students = new List<Student>();
        }
        public School(string name) : this()
        {
            Name = name;
        }
        public string Name { get; set; }
        public List<Student> Students { get => this.students; }
        public void AddStudent(string name, double grade)
        {
            this.students.Add(new Student(name, grade));
        }
        public double AverageResultInRange(int start, int end)
        {
            double sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += students[i].Grade;
            }
            return sum / (end - start + 1.0);
        }
        public List<string> RemoveStudentsByGrade(double grade)
        {
            List<string> result = new List<string>();
            foreach (var s in this.students.Where(x=>x.Grade<grade))
            { 
                result.Add(s.Name);
            }
            this.students.RemoveAll(x => x.Grade < grade);
            return result;
        }
        public List<Student> SortAscendingByName()
        {
            this.students = this.students.OrderBy(x => x.Name).ToList();
            return this.students;
        }
        public List<Student> SortDescendingByGrade()
        {
            this.students = this.students.OrderByDescending(s => s.Grade).ToList();
            return this.students;
        }
        public bool CheckStudentIsInSchool(string name)
        {
            Student s = this.students.FirstOrDefault(st => st.Name == name);
            return s != null ? true : false;
            //return s == null ? false : true;
        }
        public string[] ProvideInformationAboutAllStudents()
        {
            string[] result = new string[this.students.Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = this.students[i].ToString();
            }
            return result;
        }
    }
}
