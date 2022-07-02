public class Student
{
    public Student(string name, double grade)
    {
        this.Name = name;
        this.Grade = grade;
    }
    public string Name { get; private set; }
    public double Grade { get; private set; }
    public override string ToString()
    {
        return $"Student {this.Name} has {this.Grade:f2}.";
    }
}

