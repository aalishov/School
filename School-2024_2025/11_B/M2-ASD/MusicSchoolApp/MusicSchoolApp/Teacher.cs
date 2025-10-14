using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchoolApp
{
    public class Teacher : SchoolMember
    {
        private string specialty;

        public string Specialty
        {
            get { return specialty; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Specialty cannot be an empty string!");

                }
                else if (value == "Piano " || value == "Violin" || value == "Guitar")
                {
                    specialty = value;
                    
                }
                {
                    throw new ArgumentException("invalid value");
                }
            }
        }
        private int studentsCount;

        public int StudentsCount
        {
            get { return studentsCount; }
            set {if (value<0) 
                {
                    throw new ArgumentException("Students count cannot be negative!");
                }
                studentsCount = value; }
        }
        private double salary;

        public double Salary
        {
            get { return salary; }
            set {if (value < 0) 
                {
                    throw new ArgumentException("Salary cannot be a negative number!");
                }
                salary = value; }
        }
        private double bonus;

        public  double  Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }




        public Teacher(string name, int age,string specialty,int studentsCount,double salary,double bonus) : base(name, age)
        {
            Specialty = specialty;
            StudentsCount = studentsCount;
            Salary = salary;
            Bonus = bonus;
        }

        public override string Info()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Teacher: {Name}, Age: {Age} years  ");
            sb.AppendLine($"Specialty: {Specialty} ");
            sb.AppendLine($"Students count: {StudentsCount}  ");
            sb.AppendLine($"Salary: {Salary:f2} lv.  ");
            sb.AppendLine($"Bonus: {Bonus:f2} lv.  ");

            return sb.ToString().TrimEnd();
        }
    }
}
