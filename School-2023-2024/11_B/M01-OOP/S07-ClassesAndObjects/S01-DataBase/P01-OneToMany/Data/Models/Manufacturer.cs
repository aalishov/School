using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_OneToMany.Data.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? EstablishedOn { get; set; }

        public virtual ICollection<Model> Models { get; set; } = new List<Model>();
    }
}
