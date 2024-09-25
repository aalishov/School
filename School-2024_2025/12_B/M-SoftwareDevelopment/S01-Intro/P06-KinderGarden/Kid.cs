public class Kid : Person
{
    private int age;

    public Kid(string firstName, string lastName, string id, int age, string parentLastName, string parentGSM) : base(firstName, lastName, id)
    {
        Age = age;
        ParentLastName = parentLastName;
        ParentGSM = parentGSM;
    }

    public int Age
    {
        get { return age; }
        private set
        {
            if (value < 3 || value > 6)
            {
                throw new ArgumentException($"The child {FirstName} {LastName} age is invalid - {value}");
            }
            age = value;
        }
    }

    public string Group
    {
        get
        {
            switch (Age)
            {
                case 3: return "I";
                case 4: return "II";
                case 5: return "III";
                case 6: return "IV";
            }
            return "-";
        }
    }

    public string ParentLastName { get; private set; }

    public string ParentGSM { get; private set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, {Age}, {ParentGSM} ({ParentLastName})";
    }
}

