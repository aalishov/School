using System;
using System.Collections.Generic;
using System.Text;

namespace P09_OpinionPoll
{
    internal class Employee2
    {
        private string name;
        private int age;

        public Employee2()
        {
            Name = "No name";
            Age = 1;
        }
        public Employee2(int age) 
        {
            Name = "No name";
            Age = age;
        }
        public Employee2(string name, int age) 
        {
            Name = name;
            Age = age;
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
            }
        }
    }
}
