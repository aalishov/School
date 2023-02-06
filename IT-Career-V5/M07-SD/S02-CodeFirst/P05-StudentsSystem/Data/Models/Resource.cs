namespace P05_StudentsSystem.Data.Models
{
    using Enums;
    using System.ComponentModel.DataAnnotations;

    public class Resource
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Url { get; set; }

        public ResourceType Type { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
