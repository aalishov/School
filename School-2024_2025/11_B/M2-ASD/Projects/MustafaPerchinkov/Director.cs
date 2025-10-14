using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KURSOV_PROEKT
{
    public class Director : Person
    {
        public Director(string name, int age) : base(name, age) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Director: {Name}");
        }
    }
}