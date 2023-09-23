namespace P01_TouristSites.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Site> Sites { get; set; } = new List<Site>();
    }
}
