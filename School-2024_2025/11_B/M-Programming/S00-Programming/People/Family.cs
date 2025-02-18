using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    internal class Family
    {
        public Person Mother { get; set; }
        public Person Father { get; set; }

        private List<Child> children = new List<Child>();

        public Family(Person mother, Person father)
        {
            Mother = mother;
            Father = father;
        }

        public void AddChildData(string name, int age)
        {
            Child child = new Child(name, age, Mother, Father);
            children.Add(child);


        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Mother:{this.Mother.Name}");
            sb.AppendLine($"Father:{this.Father.Name}");

            foreach (var c in children)
            {
                sb.AppendLine(c.Name);
            }
            return sb.ToString().TrimEnd();
        }


    }
}
