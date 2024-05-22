using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kid : Person
{
    private int age;

    public Kid(string firstName, string lastName, string id, int age, string parentLastName, string parentGSM) : base(firstName, lastName, id)
    {
        Age = age;
        ParentLastName = parentLastName;
        ParentGSM = parentGSM;
    }

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value<3||value>6)
            {
                throw new ArgumentException($"The child {FirstName} {LastName} age is invalid - {value}");
            }
            age = value;
        }
    }

    public string Group
    {
        get
        {
            if (Age == 3) { return "I"; }
            else if (Age == 4) { return "II"; }
            else if (Age == 5) { return "III"; }
            else { return "IV"; }
        }
    }

    public string ParentLastName { get; set; }

    public string ParentGSM { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, {Age}, {ParentGSM} ({ParentLastName})";
    }
}

