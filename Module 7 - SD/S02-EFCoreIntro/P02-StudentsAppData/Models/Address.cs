namespace P02_StudentsAppData.Models
{
    using System.Collections.Generic;
    public class Address
    {
        public Address()
        {
            this.Students = new HashSet<Student>();
            this.Schools = new HashSet<School>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int TownId { get; set; }

        public virtual Town Town { get; set; }

        public ICollection<School> Schools { get; set; }

        public ICollection<Student>  Students { get; set; }
    }
}