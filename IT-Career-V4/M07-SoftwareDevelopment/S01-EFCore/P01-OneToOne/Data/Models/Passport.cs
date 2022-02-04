using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_OneToOne.Data.Models
{
    public class Passport
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Number { get; set; }
        public virtual Person Person { get; set; }
    }
}
