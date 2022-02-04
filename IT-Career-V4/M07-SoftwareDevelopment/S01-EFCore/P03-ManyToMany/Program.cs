using P03_ManyToMany.Data;
using P03_ManyToMany.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_ManyToMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
           AppDbContext context= new AppDbContext();

            //Student s1 = new Student() { Name = "Mila" };
            //Student s2 = new Student() { Name = "Toni" };
            //Student s3 = new Student() { Name = "Ron" };
            //Exam e1 = new Exam() { Name = "SpringMVC" };
            //Exam e2 = new Exam() { Name = "Neo4j" };
            //Exam e3 = new Exam() { Name = "Oracke11g" };
            //StudentExam se1 = new StudentExam() { Student = s1,Exam = e1 };
            //StudentExam se2 = new StudentExam() { Student = s1, Exam = e2 };
            //StudentExam se3 = new StudentExam() { Student = s2, Exam = e1 };
            //StudentExam se4 = new StudentExam() { Student = s3, Exam = e3 };
            //StudentExam se5 = new StudentExam() { Student = s2, Exam = e2 };
            //StudentExam se6 = new StudentExam() { Student = s2, Exam = e3 };

            //context.StudentsExams.AddRange(se1,se2,se3, se4, se5, se6);
            //context.SaveChanges();

            List<StudentExam> studentsExams = context.StudentsExams.OrderBy(x=>x.Student.Name).ToList();
            foreach (var se in studentsExams)
            {
                Console.WriteLine($"Student {se.Student.Name} => exam {se.Exam.Name}");
            }
        }
    }
}
