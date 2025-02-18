using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    public class Course
    {
        public Course(string name, Teacher teacher, Group group)
        {
            Name = name;
            Teacher = teacher;
            Group = group;
        }

        public string Name { get; private set; }
        public Teacher Teacher { get; private set; }
        public Group Group { get; private set; }
    }
}
