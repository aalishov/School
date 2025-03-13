using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Data.Models
{
    public class Book
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Author { get; set; }

        public string? ImageUrl { get; set; }
    }
}
