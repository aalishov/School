using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_PersonInfo
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {

        public string Name { get; private set; }
        public int Age
        {
            get { return DateTime.Now.Year - BirthDate.Year; }

        }

        public string ID { get; private set; }

        public DateTime BirthDate { get; private set; }

        public Citizen(string name, string id, DateTime birthdate)
        {
            Name = name;
            ID = id;
            BirthDate = birthdate;
        }
    }
}
