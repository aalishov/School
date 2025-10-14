using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchoolApp
{
    public abstract class SchoolMember
    {
        private string name;
        private int age;

        protected SchoolMember(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be an empty string!");
                }
                name = value;
                
            }
        }
        public int Age
        {
            get
            {
                return age;
            }

            private set
            {
                if (value<5)
                {
                    throw new ArgumentException("Age must be greater than 5 years!");
                }
                age = value;
            }
        }

        public abstract string Info();
        


     }



  
}
