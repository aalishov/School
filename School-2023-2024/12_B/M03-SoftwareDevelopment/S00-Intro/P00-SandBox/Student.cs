
    public class Student : Person
    {
        public Student(string name, int age, string school) : base(name, age)
        {
            School = school;
        }

        public string School { get; set; }

        public override void PrintAge()
        {
            Console.WriteLine($"Student: {Age}");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"\t School: {School}");
        }

    public override string ToString()
    {
        return $"{Name}, {Age}, {School}";
    }
}

