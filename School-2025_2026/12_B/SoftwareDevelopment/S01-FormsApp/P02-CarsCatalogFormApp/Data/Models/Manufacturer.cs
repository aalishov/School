using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P02_CarsCatalogFormApp.Data.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime EstablishedOn { get; set; }

        public virtual ICollection<Model> Models { get; set; } = new HashSet<Model>();
    }
}
