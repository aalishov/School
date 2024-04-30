using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40_People
{
    public class Human
    {
        public Human(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age} years old.";
        }
    }
}
