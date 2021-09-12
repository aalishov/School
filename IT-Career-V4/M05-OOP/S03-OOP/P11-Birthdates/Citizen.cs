using System;
using System.Collections.Generic;
using System.Text;

namespace P11_Birthdates
{
    public class Citizen : BaseCitizen, IName, IBirthdate
    {
        public Citizen(string id, string name, DateTime birthdate) : base(id)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get => DateTime.Now.Year - this.Birthdate.Year; }

    }
}
