using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KURSOV_PROEKT
{
    public class Actor : Person
    {
        public string Character { get; set; }

        public Actor(string name, int age) : base(name, age)
        {

        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Actor: {Name}");
        }
    }
}
