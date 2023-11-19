
public class Student
{
    //Полета
    private string name;
    private int age;

    public Student() 
    {
        Name = "John";
        Age= 15;
    }

    public Student(string name) : this()
    {
        Name = name;
    }

    public Student(int age) : this()
    {
        Age = age;
    }

    public Student(string name, int age) : this(age)
    {
        Name = name;
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
    public List<int> Grades { get; set; } = new List<int>();

    public double AverageGrade { get { return Grades.Average(); } }

    public bool Male { get; set; }

}
