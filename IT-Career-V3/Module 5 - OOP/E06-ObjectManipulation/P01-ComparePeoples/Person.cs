using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace P01_ComparePeoples
{
    public class Person:IComparable<Person>
    {
        public string Name { get; set; }

        public int Age { get; set; }


        public int CompareTo([AllowNull] Person other)
        {
            if (this.Age>other.Age)
            {
                return this.Age-other.Age;
            }
            else if (this.Age<other.Age)
            {
                return this.Age-other.Age;
            }
            else
            {
                return 0;
            }
        }
    }
}
