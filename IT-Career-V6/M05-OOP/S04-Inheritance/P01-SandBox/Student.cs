public class Student : Person
{
    public Student(string name, string address, string school) : base(name, address)
    {
        this.School = school;
    }

    public int Age { get { return this.age; } set { this.age = value; } }

    public string School { get; set; }

    //public override string GetNameAndAddress()
    //{
    //    return $"{base.GetNameAndAddress()}, student" ;
    //}
}

