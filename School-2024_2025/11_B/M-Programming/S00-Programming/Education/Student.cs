using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    public class Student
    {
        public Student(string name, int age, Group group, Speciality speciality)
        {
            Name = name;
            Age = age;
            Group = group;
            Speciality = speciality;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public Group Group { get; set; }
        public Speciality Speciality { get; set; }


    }
}
