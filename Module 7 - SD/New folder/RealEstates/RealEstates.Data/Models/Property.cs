namespace RealEstates.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Property
    {
        public Property()
        {
            this.Tags = new HashSet<TagProperty>();
        }

        [Key]
        public int Id { get; set; }

        public int Size { get; set; }

        public int? Floor { get; set; }

        public int? TotalNumberOfFloors { get; set; }

        [ForeignKey(nameof(District))]
        public int DistrictId { get; set; }

        public virtual District District { get; set; }

        public int? Year { get; set; }

        [ForeignKey(nameof(PropertyType))]
        public int PropertyTypeId { get; set; }

        public virtual PropertyType PropertyType { get; set; }

        [ForeignKey(nameof(BuildingType))]
        public int BuildingTypeId { get; set; }

        public virtual BuildingType BuildingType { get; set; }

        public int Price { get; set; }

        public virtual ICollection<TagProperty> Tags { get; set; }
    }
}
