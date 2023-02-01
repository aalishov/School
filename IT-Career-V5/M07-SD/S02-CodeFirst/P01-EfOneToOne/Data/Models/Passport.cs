namespace P01_EfOneToOne.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Passport
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(8)]
        public string Number { get; set; }

        public virtual Person Person { get; set; }
    }
}
