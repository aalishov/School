using DataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServicesLibrary
{
    public class StudentService
    {

        public string CreateStudent(int id, string firstName, string lastName, int age, string school)
        {
            Student student = new Student()
            {
                Id=id,
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                School = school,
            };
            ApplicationDbContext.Students.Add(student);
            return $"Created student {student.FirstName} {student.LastName}";
        }
        public string GetStudentInfo(int id)
        {
           Student student= ApplicationDbContext.Students.FirstOrDefault(x => x.Id == id);
            if (student!=null)
            {
                return $"{student.FirstName} {student.LastName} {student.Age}";
            }
            else
            {
              return  $"Student not found!";
            }
        }
        public string Grow(Student student)
        {
            student.Age++;
            return $"{student.FirstName} {student.LastName} growing... Age{student.Age}";
        }
    }
}

