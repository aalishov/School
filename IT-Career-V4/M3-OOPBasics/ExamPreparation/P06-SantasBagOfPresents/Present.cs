namespace P06_SantasBagOfPresents
{
    public class Present
    {
        public Present(string name, double weight, string gender)
        {
            this.Name = name;
            this.Weight = weight;
            this.Gender = gender;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public string Gender { get; set; }

        private string Info()
        {
            return $"Present { this.Name} ({ this.Weight}) for a { this.Gender}";
        }

        public override string ToString()
        {
            return Info();
        }
    }
}
