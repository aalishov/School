namespace P02_OneToMany.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Manufacturer
    {
        public Manufacturer()
        {
            this.Models = new HashSet<Model>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime? EstablishedOn { get; set; }

        public virtual ICollection<Model> Models { get; set; }
    }
}
