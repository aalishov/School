using System;
using System.Collections.Generic;
using System.Text;

public class Student:Person
{
    private int level;

    public Student(int id,string name, int level=0):base(name)
    {
        this.Id = id;
        this.Level = level;
    }
    public int Id { get; private set; }
    public int Level
    {
        get { return level; }
        set
        {
            if (level < 0)
            {
                throw new ArgumentException("Invalid age!");
            }
            level = value;
        }
    }

}

