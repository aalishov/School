namespace BookManagement.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        public int Id { get; set; }

        [MaxLength(150)]
        public string Title { get; set; }

        [MaxLength(150)]
        public string Author { get; set; }

        public int Year { get; set; }

        public double Price { get; set; }

        public virtual ICollection<BookGanre> Ganres { get; set; } = new HashSet<BookGanre>();
    }
}
