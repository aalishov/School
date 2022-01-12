using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_BorderControl
{
    public class Citizen : BaseCitizen
    {
        public Citizen(string id, string name, int age) : base(id)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
