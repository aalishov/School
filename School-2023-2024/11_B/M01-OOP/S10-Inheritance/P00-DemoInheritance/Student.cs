using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student : Person
{
    private List<int> grades = new List<int>();
    public Student(string name, int age, string school) : base(name, age)
    {
        School = school;
    }

    public string School { get; private set; }

    public double AverageGrade
    {
        get
        {
            int sum = grades.Sum();
            if (grades.Count==0)
            {
                throw new DivideByZeroException("Students grade's count: 0");
            }
            return sum / grades.Count;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $", school: {School}";
    }
}

