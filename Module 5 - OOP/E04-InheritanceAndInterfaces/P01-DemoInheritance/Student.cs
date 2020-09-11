using System;
using System.Collections.Generic;
using System.Text;

namespace P01_DemoInheritance
{
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
        }

        public string School { get; set; }
    }
}
