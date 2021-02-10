namespace RealEstates.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public  class PropertyType
    {
        public PropertyType()
        {
            this.Properties = new HashSet<Property>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
