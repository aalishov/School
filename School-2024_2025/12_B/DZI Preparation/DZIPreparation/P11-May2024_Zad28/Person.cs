using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string id;

    public Person(string firstName, string lastName, string id)
    {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Id
    {
        get
        {
            return id;
        }

        set
        {
            if (value.Length != 10)
            {
                throw new ArgumentException($"{FirstName} {LastName} - invalid identifier!");
            }
            id = value;
        }
    }
}
