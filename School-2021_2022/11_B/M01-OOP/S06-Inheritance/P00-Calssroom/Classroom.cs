using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P00_Calssroom
{
    public class Classroom
    {
        private readonly List<Student> students;
        public Classroom(int capacity)
        {
            Capacity = capacity;
            this.students = new List<Student>();
        }
        public int Capacity { get; set; }
        public int Count { get { return students.Count; } }

        public string RegisterStudent(Student student)
        {
            if (Count < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            return $"No seats in the classroom";
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            if (student != null)
            {
                students.Remove(student);
                return $"Dismissed student {student.FirstName} {student.LastName}";
            }
            return $"Student not found";
        }

        public string GetSubjectInfo(string subject)
        {
            List<Student> studentsWithSubject = students.Where(x => x.Subject == subject).ToList();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine("Students:");
            foreach (var s in studentsWithSubject)
            {
                sb.AppendLine(s.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public int GetStudentsCount()
        {
            return Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            return students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }
    }
}
