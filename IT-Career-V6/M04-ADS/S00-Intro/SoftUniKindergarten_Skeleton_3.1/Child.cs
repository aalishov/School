namespace SoftUniKindergarten
{
    public class Child
    {
        public Child(string firstName, string lastName, int age, string parentName, string contactNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ParentName = parentName;
            ContactNumber = contactNumber;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public string ParentName { get; private set; }

        public string ContactNumber { get; private set; }

        public override string ToString()
        {
            return $"Child: {FirstName} {LastName}, Age: {Age}, Contact info: {ParentName} - {ContactNumber}";
        }
    }
}
