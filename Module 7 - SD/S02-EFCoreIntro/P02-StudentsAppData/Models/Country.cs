namespace P02_StudentsAppData.Models
{
    using System.Collections.Generic;
    public class Country
    {
        public Country()
        {
            this.Towns = new HashSet<Town>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Town> Towns { get; set; }
    }
}
