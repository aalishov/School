using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstates.Data.Models
{
    public class TagProperty
    {
        [ForeignKey(nameof(Property))]
        public int PropertyId { get; set; }

        public virtual Property Property { get; set; }

        [ForeignKey(nameof(Tag))]
        public int TagId { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
