using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    public class Teacher
    {
        public Teacher(string name, string competence)
        {
            Name = name;
            Competence = competence;
        }

        public string Name { get;private set; }
        public string Competence { get;private set; }
    }
}
