namespace P01_TouristSites.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Location
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string? Municipality { get; set; }

        [MaxLength(50)]
        public string? Province { get; set; }
        public virtual ICollection<Site> Sites { get; set; } = new List<Site>();
    }
}
