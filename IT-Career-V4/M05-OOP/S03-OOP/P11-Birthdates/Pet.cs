namespace P11_Birthdates
{
    using System;
    public class Pet : IName, IBirthdate
    {
        public Pet(string name, DateTime birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
        public string Name { get ; set ; }
        public DateTime Birthdate { get ; set ; }
    }
}
