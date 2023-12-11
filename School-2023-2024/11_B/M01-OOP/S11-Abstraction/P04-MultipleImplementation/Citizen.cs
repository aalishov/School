using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_MultipleImplementation
{
    public class Citizen : IBirthable, IIdentifiable, IPerson
    {
        public Citizen(string id, string name, DateOnly birthdate)
        {
            Id = id;
            Name = name;
            Birthdate = birthdate;
        }

        public string Id { get; private set; }

        public string Name { get; private set; }

        public int Age { get => DateTime.Now.Year - Birthdate.Year; }

        public DateOnly Birthdate { get; private set; }
    }
}
