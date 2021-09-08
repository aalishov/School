namespace P06_SantasBagOfPresents
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Bag
    {
        private readonly List<Present> presents;

        public Bag(string color, int capacity)
        {
            this.Color = color;
            this.Capacity = capacity;
            this.presents = new List<Present>();
        }
        public string Color { get; private set; }
        public int Capacity { get; private set; }
        public int Count { get { return this.presents.Count; } }
        public void Add(Present present)
        {
            if (this.presents.Count > this.Capacity) { this.presents.Add(present); }
        }
        //public bool Remove(string name) => this.presents.Remove(GetPresent(name));
        public bool Remove(string name) => this.presents.Remove(this.presents.FirstOrDefault(x => x.Name == name));

        public Present GetHeaviestPresent() => this.presents.OrderByDescending(x => x.Weight).FirstOrDefault();

        public Present GetPresent(string name)
        {
            return this.presents.FirstOrDefault(x => x.Name == name);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} bag contains:");

            //this.presents.ForEach(x => sb.AppendLine(x.ToString()));

            foreach (var present in this.presents)
            {
                sb.AppendLine(present.ToString());
            }

            return sb.ToString().TrimEnd();
        }
        public override string ToString()
        {
            return Report();
        }
    }
}
