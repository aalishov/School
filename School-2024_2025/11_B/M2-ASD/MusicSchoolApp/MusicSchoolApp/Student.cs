using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchoolApp
{
    internal class Student : SchoolMember
    {
        private string instrument;

        public string Instrument
        {
            get { return instrument; }
            set { 
                if (string.IsNullOrWhiteSpace(value)) 
                {
                    throw new ArgumentException("Instrument cannot be an empty string!");

                }
                instrument = value; }
   
            
        }
        private int practiceHours;

        public int PracticeHours
        {
            get { return practiceHours; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Practice hours must be a positive number!");

                }
                practiceHours = value; }
        }


        public Student(string name, int age,string instrument,int practiceHours) : base(name, age)
        {
            Instrument = instrument;
            PracticeHours = practiceHours;
        }

        public override string Info()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Student: {Name}, Age: {Age} years");
            sb.AppendLine($"Instrument: {Instrument}");
            sb.AppendLine($"Practice hours: {PracticeHours} per week");
            return sb.ToString().TrimEnd();

        }
    }
}
