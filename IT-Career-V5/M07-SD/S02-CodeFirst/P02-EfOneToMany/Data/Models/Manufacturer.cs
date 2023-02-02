using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P02_EfOneToMany.Data.Models
{
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public DateTime? EstablishedOn { get; set; }

        public virtual ICollection<Model> Models { get; set; } = new List<Model>();
    }
}
