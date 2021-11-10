using System.Collections.Generic;

namespace P01_SoftUni.Data.Models
{
    public class Town
    {
        public Town()
        {
            this.Students = new List<Student>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Student> Students { get; set; }
    }
}
