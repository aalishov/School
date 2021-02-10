using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RealEstates.Data.Models
{
    public class Tag
    {
        public Tag()
        {
            this.Tags = new HashSet<TagProperty>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<TagProperty> Tags { get; set; }
    }
}
