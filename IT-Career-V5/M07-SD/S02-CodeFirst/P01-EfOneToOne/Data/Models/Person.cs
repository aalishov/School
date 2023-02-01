namespace P01_EfOneToOne.Data.Models
{
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "decimal(12, 4)")]
        public decimal Salary { get; set; }

        public int? Age { get; set; }

        public int PassportId { get; set; }

        public virtual Passport Passport { get; set; }
    }
}
