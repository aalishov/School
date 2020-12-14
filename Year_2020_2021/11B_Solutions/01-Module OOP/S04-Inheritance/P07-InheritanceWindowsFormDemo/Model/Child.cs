namespace P07_InheritanceWindowsFormDemo.Model
{
    public class Child : Person
    {
        public Child(string name, int age, string school, string childClass) : base(name, age)
        {
            this.School = school;
            this.ChildClass = childClass;
        }

        public string School { get; set; }

        public string ChildClass { get; set; }

        public override string ToString()
        {
            return base.ToString()+$"- {this.ChildClass} клас";
        }
    }
}
