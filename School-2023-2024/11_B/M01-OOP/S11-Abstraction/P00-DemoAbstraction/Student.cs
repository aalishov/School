using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_DemoAbstraction
{
    public class Student : BaseStudent
    {
        public Student() : this("n/a", -1)
        {

        }

        public Student(string name, int age) : base(name, age)
        {
        }

        public override void ChangeAge(int age)
        {
            Age = age;
            Console.WriteLine($"Student {Name}, age: {Age}");
        }

        public override void PrintName()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Name: {Name}, age: {Age}";
        }
    }
}
