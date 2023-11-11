
public class Student
{
    //Полета
    private string name;
    private int age;

    public Student() { }

    public Student (string name) { Name = name; }

    public Student(int  age) { Age = age; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    //Свойства
    public string Name
    {
        get
        {
            if (Male)
            {
                return $"Mr. {name}";
            }
            return name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Invalid name!");
            }
            name = value;
        }
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Invalid age!");
            }
            age = value;
        }
    }
    public List<int> Grades { get; set; }= new List<int> ();

    public double AverageGrade { get { return Grades.Average(); } }

    public bool Male { get; set; }

}
