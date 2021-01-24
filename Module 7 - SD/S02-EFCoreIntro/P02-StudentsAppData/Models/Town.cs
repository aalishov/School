namespace P02_StudentsAppData.Models
{
    using System.Collections.Generic;
    public class Town
    {
        public Town()
        {
            this.Addresses = new HashSet<Address>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public ICollection<Address>  Addresses { get; set; }
    }
}