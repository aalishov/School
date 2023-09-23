namespace P01_TouristSites.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class BonusPrize
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<TouristBonusPrize> TouristsBonusPrizes { get; set; } = new List<TouristBonusPrize>();
    }
}
