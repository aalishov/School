public class Student
{
    //Properties
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public double AverageGrade { get; set; }

    public void Grow()
    {
        this.Age++;
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName}, {this.Age} years old, average grade: {this.AverageGrade}";
    }
}
