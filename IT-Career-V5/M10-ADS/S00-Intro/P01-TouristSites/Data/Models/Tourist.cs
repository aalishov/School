namespace P01_TouristSites.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Tourist
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int Age { get; set; }

        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nationality { get; set; }

        [MaxLength(20)]
        public string? Reward { get; set; }

        public virtual ICollection<SiteTourist> SitesTourists { get; set; } = new List<SiteTourist>();
        public virtual ICollection<TouristBonusPrize> TouristsBonusPrizes { get; set; } = new List<TouristBonusPrize>();
    }
}
