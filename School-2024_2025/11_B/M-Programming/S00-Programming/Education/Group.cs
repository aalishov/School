using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    public class Group
    {
        public Group(string name, List<Student> students)
        {
            Name = name;
            Students = students;
        }

        public string Name { get; private set; }
        public List<Student> Students { get; private set; }

    }
}
