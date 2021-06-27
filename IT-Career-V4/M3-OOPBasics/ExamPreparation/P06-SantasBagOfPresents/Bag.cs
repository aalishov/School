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
        public string Color { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return this.presents.Count; } }
        public void Add(Present present)
        {
            if (this.presents.Count < this.Capacity) {  this.presents.Add(present); }
        }
        public bool Remove(string name)
        {
            return this.presents.Remove(GetPresent(name));
        }
        public Present GetHeaviestPresent()
        {
            return this.presents.OrderByDescending(x => x.Weight).FirstOrDefault();
        }
        public Present GetPresent(string name)
        {
            return this.presents.FirstOrDefault(x => x.Name == name);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} bag contains:");
            this.presents.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }
        public override string ToString()
        {
            return Report();
        }
    }
}
