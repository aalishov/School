using System;
using System.Diagnostics.CodeAnalysis;

public class Student : IComparable<Student>
{
    public string FirtName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public int CompareTo([AllowNull] Student other)
    {
        if (this.Age>other.Age)
        {
            return 1;
        }
        else if (this.Age<other.Age)
        {
            return -1;
        }
        else if (this.FirtName.CompareTo(other.FirtName)>0)
        {
            return 1;
        }
        else if (this.FirtName.CompareTo(other.FirtName) < 0)
        {
            return -1;
        }
        else if (this.LastName.CompareTo(other.LastName) > 0)
        {
            return 1;
        }
        else if (this.LastName.CompareTo(other.LastName) < 0)
        {
            return -1;
        }
        return 0;
    }
}

