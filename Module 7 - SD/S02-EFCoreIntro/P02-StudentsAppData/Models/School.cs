namespace P02_StudentsAppData.Models
{
    using System.Collections.Generic;
    public class School
    {
        public School()
        {
            this.Students = new HashSet<Student>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
