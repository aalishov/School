namespace VetClinic
{
    public class Pet
    {
        //new Pet("Buny",3,"Tim");
        public Pet(string name, int age, string owner)
        {
            this.Name = name;
            this.Age = age;
            this.Owner = owner;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Owner { get; private set; }

        public override string ToString()
        {
            return $"Name: {this.Name} Age: {this.Age} Owner: {this.Owner}";
        }
    }
}
