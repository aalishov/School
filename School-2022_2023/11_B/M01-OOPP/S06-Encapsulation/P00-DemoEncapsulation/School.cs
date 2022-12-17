using System;
using System.Collections.Generic;
using System.Text;


public class School
{
      readonly List<Student> students;

    public IReadOnlyCollection<Student> Students
    {
        get { return this.students; }
    }

}

