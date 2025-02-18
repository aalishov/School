using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    public class Grade
    {
        public Grade(Student student, Course course, string date, double gradee)
        {
            Student = student;
            Course = course;
            Date = date;
            Gradee = gradee;
        }

        public Student Student  { get;  private set; }
        public Course Course { get;  private set; }
        public string Date { get;private set; }
        public double Gradee { get; private set; }

    }
}
